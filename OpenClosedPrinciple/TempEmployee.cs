namespace OpenClosedPrinciple
{
    public class TempEmployee:Employee
    {
        public TempEmployee(int id,string name):base(id,name)
        {

        }
        public override double calculatebonus(int salary)
        {
            System.Console.WriteLine(this.Name + " " + " salary");
            return salary * 0.08;
        }
    }
}
