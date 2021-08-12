namespace Singleresponsibilityprinciple
{
    class Program
    {
        static void Main(string[] args)
        {
                standardmessage.welcomemessage();
                //ask user for information
                Person user = persondatacapture.capture();

                //checks to be sure the first and last name is valid
                bool isvalid = personvalidator.validate(user);
                if(isvalid==false)
                {
                standardmessage.endapplication();
                return;
                }
                //create a username
                accountgenerator.createaccount(user);
                standardmessage.endapplication();
        }
    }
}
