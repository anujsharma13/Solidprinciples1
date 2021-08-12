using System;

namespace InterfaceSegregationPrinciple
{
    public class canon : IBasicPrinter   //suppose cannon does not support Fax but as the interface is big so it is un usual present over here
    {
        //better way is to divide interface into parts
        //infuture if there is new feature occurs we have added it into the interface but it is not used by this class so it is unusual
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy done "+content);
            return true;
        }

        public bool printcontent(string content)
        {
            Console.WriteLine("Print done "+content);
            return true;
        }

    }
}
