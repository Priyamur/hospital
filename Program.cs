// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
public abstract class Hospital
{
    public abstract void DoctorLists();
    public void  BedLists()
    {
        Console.WriteLine("beds count at hospital ");
    }
}
class Chennai:Hospital
{
    public override void DoctorLists()
    {
        Console.WriteLine("docters name");
        Console.WriteLine("docters specialist");
        Console.WriteLine("doctors age");
    }

}
class Program
{
    public static void Main(string [] args)
    {
        Chennai mychennai = new Chennai();
        mychennai.DoctorLists();
    }

}