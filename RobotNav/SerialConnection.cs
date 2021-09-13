using System.IO.Ports;
using System.Text;

namespace RobotNav
{
    class SerialConnection
    {
        private readonly SerialPort serial = new();
        public string Port;

        public SerialConnection(string port)
        {
            Port = port;
        }
        private void OpenSerial(string name = null)
        {
            if (name is null)
            {
                name = Port;
            }
            if (serial.IsOpen)
                serial.Close();
            serial.BaudRate = 9600;
            serial.DataBits = 8;
            serial.StopBits = StopBits.One;
            serial.Parity = Parity.None;
            serial.ReadTimeout = 500;
            serial.WriteTimeout = 500;
            serial.Encoding = Encoding.ASCII;
            serial.PortName = name;

            serial.Open();
        }
        public void Send(string msg)
        {
            OpenSerial();
            serial.Write(msg + '\n');
            System.Threading.Thread.Sleep(500);
            serial.Close();
        }
        public override string ToString()
        {
            return Port.ToString();
        }
        public string ReadExisting()
        {
            return serial.ReadExisting();
        }
    }
}
