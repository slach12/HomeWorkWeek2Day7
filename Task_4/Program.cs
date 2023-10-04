namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok do sprawdzenia");
            int year = int.Parse(Console.ReadLine());    
            if (year %4  == 0) 
            {
                if ((year % 100 == 0) && (year % 400 != 0))
                {
                    Console.WriteLine($"{year} nie jest przestępny");
                }
                else
                {
                    Console.WriteLine($"{year} jest przestępny");
                }
            }
            else
            {
                Console.WriteLine($"{year} nie jest przestępny");
            }

        }
    }
}