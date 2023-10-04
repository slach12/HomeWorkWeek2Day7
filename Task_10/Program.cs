namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszy bok trójkąta:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugi bok trójkąta:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzeci bok trójkąta");
            double c = double.Parse(Console.ReadLine());

            bool condition1 = a + b > c;
            bool condition2 = b + c > a;
            bool condition3 = c + a > b;

            if (condition1 && condition2 && condition3) 
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
        }
    }
}