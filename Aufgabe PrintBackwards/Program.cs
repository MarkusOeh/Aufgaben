namespace Aufgabe_PrintBackwards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------------------- AUFGABE ----------------------
            // Drucke den gegeben Text rückwärts, wobei jedes Zeichen mit einem Leerzeichen getrennt sein soll.
            // Input: "Hamster"
            // Output: "r e t s m a H"

            Console.WriteLine("GIB EIN WORT EIN");
            string inputWord = Console.ReadLine();
            List<char> buchstabenListe = new List<char>();

            Console.WriteLine();

            foreach (char buchstabe in inputWord)
            {
                buchstabenListe.Add(buchstabe);
            }

            // Ausgabe der Liste
            Console.WriteLine("BESTEHT AUS:");
            foreach (char buchstabe in buchstabenListe)
            {
                Console.WriteLine(buchstabe);
            }
            
            Console.WriteLine();

            // Ausgabe der Liste in umgekehrter Reihenfolge
            Console.WriteLine("DIE BUCHSTABEN UMGEKEHRT SIND:");
            for (int i = buchstabenListe.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(buchstabenListe[i]);
            }
        }
    }
}
