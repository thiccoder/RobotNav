using System;
using System.Windows.Forms;

namespace RobotNav
{
    public partial class GetRobot : Form
    {
        private readonly SendSMS sms;
        public GetRobot(SendSMS parent)
        {
            InitializeComponent();
            sms = parent;
        }

        private void SubmitClick(object sender, EventArgs e)
        {
            Program.robots.Add(new(PhoneNumberUpDown.Value.ToString()));
            sms.AddNumber(new(PhoneNumberUpDown.Value.ToString()));
            Close();
        }

        private void CancelClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
