namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wzrost w cm :");
            double height = double.Parse(Console.ReadLine());
            if (height < 150)
            {
                Console.WriteLine("Jesteś krasnoludem");
            } else if (height > 240)
            {
                Console.WriteLine("Jesteś olbrzymem");
            }
            else
            {
                Console.WriteLine("Jesteś człowiekiem");
            }
        }
    }
}