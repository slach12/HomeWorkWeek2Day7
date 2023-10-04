namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wiek:");
            int age = int.Parse(Console.ReadLine());
            if (age <21) 
            {
                Console.WriteLine("Jesteś za młody , żeby kandydować.");
            }
            if (age >= 21)
            {
                Console.WriteLine("Możesz kandydować na posła.");
            }
            if(age >= 30)
            {
                Console.WriteLine("Możesz kandydować na senatora.");
            }
            if (age >= 35)
            {
                Console.WriteLine("Możesz kandydować na prezydenta.");
            }
        }
    }
}