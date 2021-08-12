using System;

namespace Singleresponsibilityprinciple
{
    public class personvalidator
        {
            public static bool validate(Person user)
            {
                if (string.IsNullOrWhiteSpace(user.firstname))
                {
                standardmessage.displayvalidationerror();
                    standardmessage.endapplication();
                    return false;
                }
                if (string.IsNullOrWhiteSpace(user.lastname))
                {
                    Console.WriteLine("not valid");
                standardmessage.displayvalidationerror();
                    return false;
                }
                return true;
            }
        }
}
