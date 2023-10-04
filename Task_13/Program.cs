namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj numer operacji do wykonania:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            int operation = int.Parse(Console.ReadLine());
            double wynik = 0;
            switch (operation){
                case 1:
                    wynik = number1 + number2;
                    break;
                case 2:
                    wynik = number2 - number1;
                    break;
                case 3:
                    wynik = number1 * number2;
                    break;
                case 4:
                    if (number2 > 0)
                    { 
                        wynik = number1 / number2;
                    }
                    break;
            }

            Console.WriteLine($"Twój wynik to {wynik}");
        }
    }
}