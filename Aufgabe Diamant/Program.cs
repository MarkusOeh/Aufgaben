namespace Aufgabe_Diamant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // ---------------------------------- AUFGABE ----------------------------------
            // Eine Funktion, welche einen Diamanten in der Konsole druckt.
            // Input: Wie gewünscht


            Console.WriteLine("WIE VIEL ZEILEN SOLL DER DIAMANT GROß SEIN?\n");
            int h = Convert.ToInt32(Console.ReadLine());
            List<string> ganzerDiamant = new List<string>();

            for (int i = 0; i < h; i++)
            {
                string zeileDiamant = new string(' ', h - i) + new string('#', i +i);
                ganzerDiamant.Add(zeileDiamant);
            }

            for (int i = 0; i < h; i++)
            {
                string zeileDiamant = new string(' ', i) + new string('#', h * 2 -2*i );
                ganzerDiamant.Add(zeileDiamant);
            }

            Console.WriteLine(string.Join("\n",ganzerDiamant));
        }
    }
}
