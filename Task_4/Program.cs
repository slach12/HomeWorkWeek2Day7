namespace Task_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok do sprawdzenia");
            int year;
            bool correctYear = int.TryParse(Console.ReadLine(), out year);
            correctYear = correctYear && year > 0;
            if (correctYear)
            {

                if (((year % 100 == 0) && (year % 400 != 0)) || (year % 4 != 0))
                {
                    Console.WriteLine($"{year} nie jest przestępny");
                }
                else
                {
                    Console.WriteLine($"{year} jest przestępny");
                }
            }
            else
            {
                Console.WriteLine("Wprowadzony rok jest nie właściwy.");
            }
        }
    }
}