using System;

namespace Singleresponsibilityprinciple
{
    public class accountgenerator
    {
        public static void createaccount(Person user)
        {
            Console.WriteLine("your username is"+user.firstname.Substring(0,1)+user.lastname);
        }
    }
}
