namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę:");
            int c = int.Parse(Console.ReadLine());
            int maxNumber = Math.Max(a, b);
            maxNumber = Math.Max(c, maxNumber);
            Console.WriteLine($"{maxNumber} jest największa z podanych");
        }
    }
}