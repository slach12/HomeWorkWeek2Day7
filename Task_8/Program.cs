namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Wynik z matematyki
            Console.WriteLine("Podaj wynik z matematyki:");
            int mathScore;
            bool mathScoreCorrect = int.TryParse(Console.ReadLine(), out mathScore);
            mathScoreCorrect &=  mathScore >= 0;
            
            //Wynik z fizyki
            Console.WriteLine("Podaj wynik z fizyki:");
            int physicScore;
            bool physicScoreCorrect = int.TryParse(Console.ReadLine(),out physicScore);
            physicScoreCorrect &= physicScore >= 0;
            
            //Wynik z chemii
            Console.WriteLine("Podaj wynik z chemii");
            int chemistryScore;
            bool chemistryScoreCorrect = int.TryParse(Console.ReadLine(), out chemistryScore);
            chemistryScoreCorrect &= chemistryScore >= 0;

            if (mathScoreCorrect &&  physicScoreCorrect && chemistryScoreCorrect) 
            {
                bool condition1 = (mathScore > 70) && (physicScore > 55) && (chemistryScore > 45)
                            && (mathScore + physicScore + chemistryScore > 180);

                bool condition2 = (mathScore + physicScore > 150) || (mathScore + chemistryScore > 150);

                if (condition1 || condition2)
                {
                    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
                }
            }
            else
            {
                if (!mathScoreCorrect)
                {
                    Console.WriteLine("Podano nie prawidłowy wynik dla matematyki.");
                }
                if (!physicScoreCorrect)
                {
                    Console.WriteLine("Podano nie prawidłowy wynik dla fizyki.");
                }
                if (!chemistryScoreCorrect)
                {
                    Console.WriteLine("Podano nie prawidłowy wynik dla chemii.");
                }
            }
            
        }
    }
}