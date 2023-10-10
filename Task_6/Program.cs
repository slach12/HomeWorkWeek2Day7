namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wzrost w cm :");
            double height ;
            bool correctHeight = double.TryParse(Console.ReadLine(), out height);
            correctHeight = correctHeight && height > 0;
            if (correctHeight)
            {
                if (height < 150)
                {
                    Console.WriteLine("Jesteś krasnoludem");
                }
                else if (height > 240)
                {
                    Console.WriteLine("Jesteś olbrzymem");
                }
                else
                {
                    Console.WriteLine("Jesteś człowiekiem");
                }
            }
            else
            {
                Console.WriteLine("Wprowadzony ciąg nie jest prawidłowym wzrostem.");
            }
        }
    }
}