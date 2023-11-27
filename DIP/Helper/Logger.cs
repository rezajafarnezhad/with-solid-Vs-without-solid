namespace DIP.Helper
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }


        public void aa()
        {
            int valueType = 12;
            object refrenceType = 77;
            refrenceType = valueType; //Boxing
            valueType = (int)refrenceType; //UnBoxing

        }
    }
}
