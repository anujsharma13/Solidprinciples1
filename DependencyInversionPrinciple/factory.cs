namespace DependencyInversionPrinciple
{
    //DIP -> high level modules does not depend on low level modules rather they depends on abstractions (interfaces) and those abstraction does not know about how things are done (as interface does not know the implementation)
    //interfaces are highlevel modules and classes are low level
    // most common way to use DIP id dependency injection
    // all the new statements should present in one class like factory example by this we need not to change new in every class
    // by dip we also get benefit in unit testing


    // visual studio also used dip as on the above bar there are many options and in every option there are sub options basically the suboptions is implemnted using dependency injection

    public static class factory
    {
        public static Iperson Createperson()
        {
            return new person();
        }
        public static IWork createchore()
        {
            return new Work(createlogger(),createemail());
        }
        public static Iemailer createemail()
        {
            return new emailer();
        }
        public static Ilogger createlogger()
        {
            return new logger();
        }
    }
}
