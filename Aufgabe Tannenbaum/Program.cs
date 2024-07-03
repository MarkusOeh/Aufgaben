namespace Aufgabe_Tannenbaum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BaumBauer v.1.0");
            int hashNumber = 1;
            int whitespaceAmount = height - 2;
            for (int i = 0; i < height; i++) // Eine Zeile
            {
                // Whitespace vor dem #
                for (int j = 0; j < whitespaceAmount; j++)
                {
                    Console.Write(" ");
                }
                // hashtags => #
                for (int j = 0; j < hashNumber; j++)
                {
                    Console.Write("#");
                }
                /* auch mit if möglich
                 if (height == i - 1) { }
                 Nach jeder Zeile
                hashNumber += 2;
                */
                whitespaceAmount--;
                Console.WriteLine();
            }
            // spezialfall
            whitespaceAmount = height - 2;
            // Whitespace vor dem #
            for (int j = 0; j < whitespaceAmount; j++)
            {
                Console.Write(" ");
            }
            Console.Write("#");
        }
    }
}
