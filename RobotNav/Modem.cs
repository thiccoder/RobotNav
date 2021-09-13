using System.IO.Ports;
using System.Text;
using System.Management;

namespace RobotNav
{
     class Modem
    {
        private readonly SerialPort serial = new();
        public string Port;
        public string Name;

        public Modem(string name)
        {
            Name = name;
            foreach (var port in SerialPort.GetPortNames())
            {
                if (port is null) continue;
                OpenSerial(port);
                serial.WriteLine("AT \r\n");
                System.Threading.Thread.Sleep(500);
                if (serial.ReadExisting().Trim().Trim('\n').Trim('\r').EndsWith("OK")) 
                {
                    Port = port;
                    break;
                }
            }
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
            serial.PortName =  name;

            serial.Open();
        }
        public void Send(PhoneNumber Number,string text)
        {
            OpenSerial();
            serial.WriteLine("AT \r\n");
            System.Threading.Thread.Sleep(500);
            serial.Write("AT+CMGF=1 \r\n");
            System.Threading.Thread.Sleep(500);
            serial.Write("AT+CMGS=\"" + Number.ToString() + "\"\r\n");
            System.Threading.Thread.Sleep(500);
            serial.Write(text + char.ConvertFromUtf32(26) + "\r\n");
            System.Threading.Thread.Sleep(500);
            serial.Close();
        }
        public override string ToString() 
        {
            return Name + string.Format(" ({0})", Port);
        }
        public string ReadExisting() 
        {
            return serial.ReadExisting();
        }
    }
}
