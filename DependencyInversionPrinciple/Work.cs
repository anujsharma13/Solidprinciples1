namespace DependencyInversionPrinciple
{
    public class Work : IWork
    {
        public Ilogger _ilogger;
        public Iemailer _iemailer;

        public string Workname { get ; set; }
        public double hoursworked { get ; set ; }
        public bool iscomplete { get ; set ; }
        public Iperson owner { get; set; }

        public Work(Ilogger ilogger,Iemailer iemailer)
        {
            _ilogger = ilogger;
            _iemailer = iemailer;
        }
       
        public void performedwork(double hours)
        {
            hoursworked += hours;
           
            _ilogger.log(Workname);
        }
        public void completework()
        {
            iscomplete = true;

            _ilogger.log(Workname);

            _iemailer.sendmail(owner, Workname);
        }
    }
}
