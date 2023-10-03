namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę :");
            int liczba = int.Parse(Console.ReadLine());
            if (liczba > 0) 
            {
                Console.WriteLine($"{liczba} jest liczbą dodatnią");
            }
            else if (liczba < 0) 
            {
                Console.WriteLine($"{liczba} jest liczbą ujemną");
            }
            else
            {
                Console.WriteLine($"{liczba} nie jest ani liczbą dodatnią ani ujemną");
            }
            
            Console.WriteLine("Hello, World!");
        }
    }
}