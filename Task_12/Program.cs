namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer dnia tygodnia:");
            int day ;
            if (int.TryParse(Console.ReadLine(), out day))
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Poniedziałek");
                        break;
                    case 2:
                        Console.WriteLine("Wtorek");
                        break;
                    case 3:
                        Console.WriteLine("Środa");
                        break;
                    case 4:
                        Console.WriteLine("Czwartek");
                        break;
                    case 5:
                        Console.WriteLine("Piątek");
                        break;
                    case 6:
                        Console.WriteLine("Sobota");
                        break;
                    case 7:
                        Console.WriteLine("Niedziela");
                        break;
                    default:
                        Console.WriteLine("Podałeś zły numer tygodnia. Liczba nie należy do przedziału od 1 do 7.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Wprowadzony ciąg nie jest liczbą.");
            }
            
        }
    }
}