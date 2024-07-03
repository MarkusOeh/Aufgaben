namespace Aufgabe_OnlyEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------- AUFGABE ----------------------------------
            // Gebe eine neue Liste zurück, welche nur alle geraden Zahlen beinhaltet.
            // Input: [1,2,3,4,5,6]
            // Output: [2,4,6]
            // Formel "if (i % 2 == 0)" prüft ob Zahlen durch 2 teilbar sind

            List<string> ausgabeListe = new();
            List<int> inputNumbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine($"WIR HABEN DIE ZAHLEN {inputNumbers[0]}, {inputNumbers[1]}, {inputNumbers[2]}, {inputNumbers[3]}, {inputNumbers[4]}, {inputNumbers[5]}\nPRÜFE AUF GERADE ZAHLEN\n");

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (inputNumbers[i] % 2 == 0) 
                {
                    Console.WriteLine($"ZAHL {inputNumbers[i]} IST EINE GERADE ZAHL");
                }
            }

        }
    }
}
