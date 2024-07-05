namespace Aufgabe_Letztes_Wort_Buchstaben_Zählen
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // ---------------------- AUFGABE ----------------------
            // Eine Funktion, welche die Anzahl an Buchstaben des letzten Wortes des Textes zurückgibt.
            // Input: "Döner mit Scharf"
            // Output: 6


            Console.WriteLine("GIB EINEN SATZ EIN\n");
            string userInput = Console.ReadLine().ToLower();
            List<char> zeichenListe = new List<char>();
            List<char> letztesWort = new List<char>();

            foreach (char c in userInput)
            {
                zeichenListe.Add(c);
            }

            for (int i = zeichenListe.Count - 1; i >= 0; i--)
            {
                if (zeichenListe[i] == 'a' || zeichenListe[i] == 'b' || zeichenListe[i] == 'c' || zeichenListe[i] == 'd' || zeichenListe[i] == 'e' || zeichenListe[i] == 'f' || zeichenListe[i] == 'g' || zeichenListe[i] == 'h' || zeichenListe[i] == 'i' || zeichenListe[i] == 'j' || zeichenListe[i] == 'k' || zeichenListe[i] == 'l' || zeichenListe[i] == 'm' || zeichenListe[i] == 'n' || zeichenListe[i] == 'o' || zeichenListe[i] == 'p' || zeichenListe[i] == 'q' || zeichenListe[i] == 'r' || zeichenListe[i] == 's' || zeichenListe[i] == 't' || zeichenListe[i] == 'u' || zeichenListe[i] == 'v' || zeichenListe[i] == 'w' || zeichenListe[i] == 'x' || zeichenListe[i] == 'y' || zeichenListe[i] == 'z' || zeichenListe[i] == 'ä' || zeichenListe[i] == 'ö' || zeichenListe[i] == 'ü' || zeichenListe[i] == 'ß')
                {
                    letztesWort.Add(zeichenListe[i]);
                }

                else break;
            }

            Console.WriteLine($"\nDAS LETZTE WORT IM SATZ HAT {letztesWort.Count} BUCHSTABEN");
        }
    }
}
