namespace OpenClosedPrinciple
{
    public abstract class Employee
    {
       public string Name;
       public int Id;
       public Employee(int id ,string name)
        {
            Name = name;
            Id = id;
        }
        public abstract double calculatebonus(int salary);
    }
}
