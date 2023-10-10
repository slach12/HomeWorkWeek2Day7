namespace Task_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wiek:");
            int age;
            bool correctAge = int.TryParse(Console.ReadLine(), out age);
            correctAge = correctAge && age > 0;
            if (correctAge)
            {
                if (age < 21)
                {
                    Console.WriteLine("Jesteś za młody , żeby kandydować.");
                }
                if (age >= 35)
                {
                    Console.WriteLine("Możesz kandydować na posła, senatora i prezydenta.");
                }
                else if (age >= 30)
                {
                    Console.WriteLine("Możesz kandydować na posła i senatora.");
                }
                else if (age >= 21)
                {
                    Console.WriteLine("Możesz kandydować na posła.");
                }
            }
            else
            {
                Console.WriteLine("Nie podałeś wieku.");
            }

        }
    }
}