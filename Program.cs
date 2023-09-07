// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
public abstract class Hospital
{
    public abstract void DoctorLists();
    public abstract void BedLists();
    {
        Console.WriteLine("beds count at hospital ")
    }
}
class Chennai:Hospital
{
    public override void DocterLists();
    {
        Console.WriteLine("docters name");
        Console.WriteLine("docters specialist");
        Console.WriteLine("doctors age");
    }

}
class program
{
    static void Main(string [] args)
    {
        Chennai mychennai = new chennai();
        mychennai.DocterLists();
    }

}