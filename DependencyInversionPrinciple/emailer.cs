using System;

namespace DependencyInversionPrinciple
{
    public class emailer : Iemailer
    {
        public void sendmail(Iperson p, string s)
        {
            Console.WriteLine("Mailed Message " + s);
        }
    }
}
