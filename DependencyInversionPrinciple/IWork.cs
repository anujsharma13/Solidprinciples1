namespace DependencyInversionPrinciple
{
    public interface IWork
    {
        string Workname { get; set; }
        double hoursworked { get; set; }
        bool iscomplete { get; set; }
        Iperson owner { get; set; }

        void completework();
        void performedwork(double hours);
    }
}