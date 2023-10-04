namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę :");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 != 0)
            {
                Console.WriteLine($"{number} jest nie parzysta");
            }
            else 
            {
                Console.WriteLine($"{number} jest parzysta");
            }
        }
    }
}