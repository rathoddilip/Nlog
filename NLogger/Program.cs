using NLog;
using System;

namespace NLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int zero = 0;
                int result = 10 / zero;
            }
            catch (Exception ex)
            {
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Error(ex);
            }           
            Console.WriteLine("Nlog file");
            Console.ReadLine();
        }
    }
}
