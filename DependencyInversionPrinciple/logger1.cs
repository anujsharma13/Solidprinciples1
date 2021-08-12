using System;

namespace DependencyInversionPrinciple
{
    public class logger : Ilogger
    {
        public void log(string s)
        {
            Console.WriteLine("loggged message " + s);
        }
    }
}
