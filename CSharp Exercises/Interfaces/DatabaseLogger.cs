using System;

namespace Interfaces
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Database'e yazar");
        }
    }
}
