namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Hplaserjet hplaserjet = new Hplaserjet();
            hplaserjet.FaxContent("fax hp");
            hplaserjet.printcontent("print hp");
            hplaserjet.Scancontent("scan hp ");
            hplaserjet.PhotoCopyContent("photo copy hp");

            canon c = new canon();
            c.PhotoCopyContent("photo copy canon");
            c.printcontent("print canon");
        }
    }
}
