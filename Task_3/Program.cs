namespace Task_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę :");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number > 0)
                {
                    Console.WriteLine($"{number} jest liczbą dodatnią");
                }
                else if (number < 0)
                {
                    Console.WriteLine($"{number} jest liczbą ujemną");
                }
                else
                {
                    Console.WriteLine($"{number} nie jest ani liczbą dodatnią ani ujemną");
                }
            }
            else 
            { 
                Console.WriteLine("Nie wprowadzono liczby.");
            }
            
            
            
        }
    }
}