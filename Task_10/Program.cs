namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszy bok trójkąta:");
            double a ;
            bool correctA = double.TryParse(Console.ReadLine(), out a);
            correctA &= a > 0;
            Console.WriteLine("Podaj drugi bok trójkąta:");
            double b;
            bool correctB = double.TryParse(Console.ReadLine(),out b);
            correctB &= b > 0;
            Console.WriteLine("Podaj trzeci bok trójkąta");
            double c;
            bool correctC = double.TryParse(Console.ReadLine(),out c);
            correctC &= c > 0;
            if (correctA && correctB && correctC)
            {
                bool condition1 = a + b > c;
                bool condition2 = b + c > a;
                bool condition3 = c + a > b;

                if (condition1 && condition2 && condition3)
                {
                    Console.WriteLine("Można zbudować trójkąt");
                }
                else
                {
                    Console.WriteLine("Nie można zbudować trójkąta");
                }
            }
            else
            {
                if (! correctA)
                {
                    Console.WriteLine("Nie prawidłowa wartość boku a");
                }
                if(!correctB)
                {
                    Console.WriteLine("Nie prawidłowa wartość boku b");
                }
                if (!correctC)
                {
                    Console.WriteLine("Nie prawidłowa wartość boku c");
                }
            }
            
        }
    }
}