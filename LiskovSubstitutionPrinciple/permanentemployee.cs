using System;

namespace LiskovSubstitutionPrinciple
{
    public class permanentemployee : employee,IEmployee
    {
        public void employeetype()
        {
            Console.WriteLine("permanent");
        }
    }
}
