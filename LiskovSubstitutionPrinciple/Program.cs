namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
          
            IEmployee e1 = new permanentemployee();
            IEmployee e2 = new tempemployee();

            e1.employeetype();
            e2.employeetype();
        }
    }
}
