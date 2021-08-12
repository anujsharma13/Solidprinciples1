namespace DependencyInversionPrinciple
{
    public interface Iemailer
    {
        void sendmail(Iperson p, string s);
    }
}