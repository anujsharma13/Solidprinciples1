using System;

namespace LiskovSubstitutionPrinciple
{
    public class tempemployee:employee,IEmployee
    {
        public void employeetype()
        {
            Console.WriteLine("temporary");
        }
    }
}
