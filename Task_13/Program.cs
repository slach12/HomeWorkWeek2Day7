namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            double number1;
            bool number1Correct = double.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Podaj drugą liczbę:");
            double number2;
            bool number2Correct = double.TryParse(Console.ReadLine(), out number2);
            if (number1Correct && number2Correct) 
            {
                Console.WriteLine("Podaj numer operacji do wykonania:");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnożenie");
                Console.WriteLine("4. Dzielenie");
                int operation ;
                double wynik = 0;
                if (int.TryParse(Console.ReadLine(), out operation))
                {
                    switch (operation)
                    {
                        case 1:
                            wynik = number1 + number2;
                            Console.WriteLine($"Twój wynik to {wynik}");
                            break;
                        case 2:
                            wynik = number2 - number1;
                            Console.WriteLine($"Twój wynik to {wynik}");
                            break;
                        case 3:
                            wynik = number1 * number2;
                            Console.WriteLine($"Twój wynik to {wynik}");
                            break;
                        case 4:
                            if (number2 != 0)
                            {
                                wynik = number1 / number2;
                                Console.WriteLine($"Twój wynik to {wynik}");
                            }
                            else
                            {
                                Console.WriteLine("Nie można dzielić przez 0.");
                            }
                            break;
                        default:
                            Console.WriteLine("Wybrałeś złą operację.");
                            break;
                    }
                    
                } 
                else
                {
                    Console.WriteLine("Nie podałeś prawidłowej liczby.");
                }
                
            }
            else
            {
                Console.WriteLine("Nie podaleś prawidłowych liczb.");
            }
            
        }
    }
}