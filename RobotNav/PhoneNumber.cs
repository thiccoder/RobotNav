namespace RobotNav
{
    public struct PhoneNumber
    {
        readonly long number;
        public PhoneNumber(string number) 
        {
            this.number = long.Parse(number.Trim('+'));
        }
        public override string ToString() 
        {
            return number.ToString();
        }
    }
}