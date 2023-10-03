namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę :");
            int liczba = int.Parse(Console.ReadLine());
            if (liczba % 2 != 0)
            {
                Console.WriteLine($"{liczba} jest nie parzysta");
            }
            else 
            {
                Console.WriteLine($"{liczba} jest parzysta");
            }
        }
    }
}