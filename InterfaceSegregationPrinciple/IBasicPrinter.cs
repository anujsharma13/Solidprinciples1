namespace InterfaceSegregationPrinciple
{
    //It is better to have many small interfaces than to have one big interface
    //problem xerox has created a new printer ystem that could perform a variety of tasks such as stapling and faxing
    //along with printing
    public interface IBasicPrinter
    {
        bool printcontent(string content);
        
        bool PhotoCopyContent(string content);
    }
}
