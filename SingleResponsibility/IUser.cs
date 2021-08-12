namespace SingleResponsibility
{
    // here a interface dont depend on single responsibility so have to break it into parts
    //interface IUser
    //{
    //    bool Login(string name, string password);
    //    bool register(string name, string password);
    //    bool Logerror(string error);
    //    bool SendEmail(string emailcontent);
    //}
    public interface IUser
    {
        bool Login(string name, string password);
       bool register(string name, string password);
    }
}
