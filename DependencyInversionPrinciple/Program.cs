using System;

namespace DependencyInversionPrinciple
{
    class Program     
    {
        static void Main(string[] args)        //main function is higl level module because it depends on others to work
        {

            // in this example chore is high level module as it use all person,emailer and logger in chore class and all the three are low level
            Iperson owner1 = factory.Createperson();

            owner1.firstname = "anuj";
            owner1.lastname = "sharma";
           owner1.email = "2000anujsharma@gmail.com";
           owner1.phoneno = "12345";

            IWork ch = factory.createchore();

            ch.Workname = " work : take the trash";
               ch.owner = owner1;
            
            ch.performedwork(3);
            ch.performedwork(1.5);
            ch.completework();
            Console.ReadLine();
        }
    }
}
