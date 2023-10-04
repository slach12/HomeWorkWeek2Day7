namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę :");
            int number = int.Parse(Console.ReadLine());
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
            
            Console.WriteLine("Hello, World!");
        }
    }
}