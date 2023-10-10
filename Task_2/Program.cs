namespace Task_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę :");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine($"{number} jest nie parzysta");
                }
                else
                {
                    Console.WriteLine($"{number} jest parzysta");
                }
            }
            else
            { 
                Console.WriteLine("Nie podałeś liczby.");
            }

        }
    }
}