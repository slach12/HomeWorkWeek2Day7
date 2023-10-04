namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj temperaturę:");
            int temperature = int.Parse(Console.ReadLine());
            if (temperature < 0)
            {
                Console.WriteLine("Cholernie piździ");
            }
            else if (temperature < 10)
            {
                Console.WriteLine("Zimno");
            } 
            else if (temperature < 20)
            {
                Console.WriteLine("Chłodno");
            }
            else if (temperature < 30)
            {
                Console.WriteLine("W sam raz");
            }
            else if (temperature < 40)
            {
                Console.WriteLine("Zaczyna być słabo, bo gorąco ");
            }
            else
            {
                Console.WriteLine("A weź wyprowadzam się na Alaskę");
            }

        }
    }
}