namespace OpenClosedPrinciple
{
    public class PermanentEmployee:Employee
    {
        public PermanentEmployee(int id,string name):base(id,name)
        {

        }
        public override double calculatebonus(int salary)
        {
            System.Console.WriteLine(this.Name+" "+" salary");
            return salary * 0.1;
        }
    }
}
