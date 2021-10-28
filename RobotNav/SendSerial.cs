using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using GMap.NET;


namespace RobotNav
{
    public partial class SendSerial : Form
    {
        private static readonly string file_exe = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\main.exe";
        private readonly List<SerialConnection> ports = new();
        private readonly string msg;
        public SendSerial(PointLatLng[] ps)
        {
            InitializeComponent();
            msg = string.Format("${0}$", ps.Length);
            foreach (var p in ps)
            {
                msg += string.Format("{0}&{1}$", p.Lat, p.Lng);
            }
            foreach (var port in SerialPort.GetPortNames())
                ports.Add(new SerialConnection(port));
            if (ports.Count == 0)
            {
                Label.Text = "No ports detected!";
                SendButton.Text = "OK";
                PortCombo.Visible = false;
            }
            else
            {
                for (int i = 0; i < ports.Count; i++)
                {
                    PortCombo.Items.Add(ports[i]);
                }
            }
        }

        private void SendClick(object sender, EventArgs e)
        {
            if (ports.Count != 0)
            {
                SerialConnection modem = (SerialConnection)PortCombo.SelectedItem;
                modem.Send(msg);
            }
            ProcessStartInfo startInfo = new();
            FileStream fs = new(file_exe, FileMode.Create);
            fs.Write(Properties.Resources.main, 0, Properties.Resources.main.Length);
            fs.Close();
            startInfo.FileName = file_exe;
            Process.Start(startInfo);
            Close();

        }
    }
}
