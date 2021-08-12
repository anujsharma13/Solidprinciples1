using System;

namespace Singleresponsibilityprinciple
{
    public class standardmessage
    {
        public static void welcomemessage()
        {
            Console.WriteLine("welcome to my application");
        }
        public static void endapplication()
        {
            Console.ReadLine();
        }
        public static void displayvalidationerror()
        {
            Console.WriteLine("not valid");
        }
    }
}
