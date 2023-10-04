namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wynik z matematyki:");
            int mathScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wynik z fizyki:");
            int physicScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wynik z chemii");
            int chemistryScore = int.Parse(Console.ReadLine());
            bool condition1 = (mathScore > 70) && (physicScore > 55) && (chemistryScore > 45)
                        && (mathScore + physicScore+ chemistryScore > 180);

            bool condition2 = (mathScore + physicScore > 150) || (mathScore + chemistryScore > 150);

            if (condition1 || condition2)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
        }
    }
}