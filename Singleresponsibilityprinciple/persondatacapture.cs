using System;

namespace Singleresponsibilityprinciple
{
    public class persondatacapture
        {
            public static Person capture()
            {
                Person user = new Person();
                Console.WriteLine("what is your first name");
                user.firstname = Console.ReadLine();
                Console.WriteLine("enter last name");
                user.lastname = Console.ReadLine();
                return user;
            }
        }
}
