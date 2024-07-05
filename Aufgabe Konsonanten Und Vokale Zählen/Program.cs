namespace Aufgabe_Konsonanten_Und_Vokale_Zählen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------------------- AUFGABE ----------------------
            // Eine Funktion, welche einen beliebigen Text als Input bekommt und in der Konsole die Anzahl an Vokalen und Konsonanten anzeigt.
            // Beispiel
            // Input: "lorem ipsum dolor est"
            // Output: Anzahl Vokale: 7
            //         Anzahl Konsonanten: 11

            // input als char list speichern. untersuchen auf konsonanten, vokale, sonderzeichen. bennenen mit 1, 2 oder 3.
            // 1 und 2 in listen speichern. listen 1 und 2 ausgeben

            Console.WriteLine("ZÄHLT DIE ANZAHL DER VOKALE UND KONSONANTEN IN EINEM SATZ\n\nBITTE SATZ EINGEBEN:\n");
            List<char> zeichenListe = new List<char>();
            string userInput = Console.ReadLine().ToLower();
            List<char> listeVokale = new List<char>();
            List<char> listeKonsonanten = new List<char>();
            List<char> listeAndere = new List<char>();

            foreach (char zeichen in userInput)
            {
                zeichenListe.Add(zeichen);
            }

            foreach (char zeichen in userInput)
            {
                if (zeichen == 'a' || zeichen == 'e' || zeichen == 'i' || zeichen == 'o' || zeichen == 'u' ||
                zeichen == 'ä' || zeichen == 'ö' || zeichen == 'ü')
                {
                    listeVokale.Add(zeichen);
                }

                else if (zeichen == 'b' || zeichen == 'c' || zeichen == 'd' || zeichen == 'f' || zeichen == 'g' || zeichen == 'h' || zeichen == 'j' || zeichen == 'k' || zeichen == 'l' || zeichen == 'm' || zeichen == 'n' || zeichen == 'p' || zeichen == 'q' || zeichen == 'r' || zeichen == 's' || zeichen == 't' || zeichen == 'v' || zeichen == 'w' || zeichen == 'x' || zeichen == 'y' || zeichen == 'z')
                {
                    listeKonsonanten.Add(zeichen);
                }

                else
                {
                    listeAndere.Add(zeichen);
                }
            }

            Console.WriteLine($"\n---> DEIN SATZ ENTHÄLT\n{listeVokale.Count} VOKALE\n{listeKonsonanten.Count} KONSONANTEN");
        }
    }
}
