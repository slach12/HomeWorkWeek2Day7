namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ocenę:");
            int mark = int.Parse(Console.ReadLine());

            switch (mark)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
            }
        }
    }
}