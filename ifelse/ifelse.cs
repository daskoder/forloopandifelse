namespace ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjutamisetest, Kirjutage Jah.");
string a = Console.ReadLine();
if (a == "Jah")
{
    Console.WriteLine("Kirjutage 1");
    int b = Convert.ToInt32 (Console.ReadLine());
    if (b == 1)
    {
        Console.WriteLine("Sa sisestasidki");
    }
    else 
     {
        Console.WriteLine("Vale sisestus");
     }
}
        }
    }
}