namespace Proje3
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("Ededleri daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());    
            int b = Convert.ToInt32(Console.ReadLine());
            int c = (a+b)/2;
            Console.WriteLine(c);
        }
    }
}