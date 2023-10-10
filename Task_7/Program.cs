namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string warning = "Wprowadzony ciąg nie jest prawidłową liczbą. Nastąpi koniec programu.";
            Console.WriteLine("Podaj pierwszą liczbę:");
            int a ;
            if (! int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine(warning);
            }
            else
            {
                Console.WriteLine("Podaj drugą liczbę:");
                int b;
                if (! int.TryParse(Console.ReadLine(),out b))
                {
                    Console.WriteLine(warning);
                }
                else
                {
                    Console.WriteLine("Podaj trzecią liczbę:");
                    int c;
                    if (int.TryParse(Console.ReadLine(),out c))
                    {
                        int maxNumber = Math.Max(a, b);
                        maxNumber = Math.Max(c, maxNumber);
                        Console.WriteLine($"{maxNumber} jest największa z podanych");
                    }
                    else
                    {
                        Console.WriteLine(warning);
                    }
                }
            }    
        }
    }
}