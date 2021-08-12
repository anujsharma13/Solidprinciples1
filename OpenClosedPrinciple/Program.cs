using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new PermanentEmployee(1, "John");
            Employee e2 = new TempEmployee(2, "Johnson");
            Console.WriteLine(e1.calculatebonus(100000));
            Console.WriteLine(e2.calculatebonus(100000));
        }
    }
}
