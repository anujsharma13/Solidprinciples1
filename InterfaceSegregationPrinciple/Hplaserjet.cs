using System;

namespace InterfaceSegregationPrinciple
{
    class Hplaserjet : IBasicPrinter,IFaxPrinter,IScanPrinter
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("fax done "+content);
            return true;
        }

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

        public bool Scancontent(string content)
        {
            Console.WriteLine("Scan done "+content);
            return true;
        }
    }
}
