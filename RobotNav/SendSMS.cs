using System;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;
using GMap.NET;

namespace RobotNav
{
    public partial class SendSMS : Form
    {
        private readonly List<Modem> modems = new();
        private readonly string msg;
        public SendSMS(PointLatLng[] ps)
        {
            InitializeComponent();
            msg = string.Format("${0}$", ps.Length);
            foreach (var p in ps)
            {
                msg += string.Format("{0}&{1}$", p.Lat, p.Lng);
            }
            ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity WHERE ClassGuid=\"{4d36e96d-e325-11ce-bfc1-08002be10318}\" "))
                collection = searcher.Get();

            foreach (var device in collection)
            {
                modems.Add(new Modem(device["Name"].ToString()));
            }
            collection.Dispose();

            if (modems.Count == 0)
            {
                label0.Text = "No modems detected!";
                label1.Visible = false;
                RobotCombo.Visible = false;
                SendButton.Text = "OK";
                AddButton.Visible = false;
                ModemCombo.Visible = false;
            }
            else
            {
                for (int i = 0; i < modems.Count; i++)
                {
                    ModemCombo.Items.Add(modems[i]);
                }
                for (int i = 0; i < Program.robots.Count; i++)
                {
                    RobotCombo.Items.Add(Program.robots[i]);
                }
            }
        }

        private void SendClick(object sender, EventArgs e)
        {
            if (modems.Count != 0)
            {
                Modem modem = (Modem)ModemCombo.SelectedItem;
                PhoneNumber number = (PhoneNumber)RobotCombo.SelectedItem;
                modem.Send(number, msg);
            }
            Close();
        }

        private void AddClick(object sender, EventArgs e)
        {
            var robot = new GetRobot(this)
            {
                TopMost = true
            };
            robot.Show();    
        }
        public void AddNumber(PhoneNumber number) 
        {
            RobotCombo.Items.Add(number);
        }
    }
}
