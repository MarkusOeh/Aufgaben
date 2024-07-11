namespace Calculator_mit_ENums
{
    public static class Calculator
    {
        /* Properties
        public string Title { get; set; }
        public int InstanceCount { get; set; }
        public string Title { get; set; }
        */
        public static int Count { get; set; }

        // Methoden
        public static int GetNumberInput(string inputPrompt) // Funktionssignatur -> Methodensignatur
        { // Function-Body -> Funktionskörper
            Console.Write(inputPrompt);
            return int.Parse(Console.ReadLine());
        }
        public static int GetNumberInputTriangle(string inputPrompt) // Funktionssignatur -> Methodensignatur
        { // Function-Body -> Funktionskörper
            Console.Write(inputPrompt);
            return int.Parse(Console.ReadLine());
        }
        public static int GetNumberInputCircle(string inputPrompt) // Funktionssignatur -> Methodensignatur
        { // Function-Body -> Funktionskörper
            Console.Write(inputPrompt);
            return int.Parse(Console.ReadLine());
        }
        public static int GetNumberInputRectangle(string inputPrompt) // Funktionssignatur -> Methodensignatur
        { // Function-Body -> Funktionskörper
            Console.Write(inputPrompt);
            return int.Parse(Console.ReadLine());
        }

        /* Calculate()
        Refactoring -> Umschreiben vom Code zum Verbessern der Performance, Lesbarkeit oder auch Wartbarkeit */
        public static int Calculate(int numberInput1, int numberInput2, Operator op)
        {
            int result = 0;
            Count++;
            Console.ForegroundColor = ConsoleColor.Magenta;
            switch (op)
            {
                case Operator.Add:
                    result = numberInput1 + numberInput2;
                    Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} = {result}");
                    break;
                case Operator.Subtract:
                    result = numberInput1 - numberInput2;
                    Console.WriteLine($"Das Ergebnis von {numberInput1} - {numberInput2} = {result}");
                    break;
                case Operator.Multiply:
                    result = numberInput1 * numberInput2;
                    Console.WriteLine($"Das Ergebnis von {numberInput1} * {numberInput2} = {result}");
                    break;
                case Operator.Divide:
                    result = numberInput1 / numberInput2;
                    Console.WriteLine($"Das Ergebnis von {numberInput1} / {numberInput2} = {result}");
                    break;
                case Operator.Triangle:
                    result = (numberInput1 * numberInput2) / 2;
                    Console.WriteLine($"({numberInput1} * {numberInput2}) : 2 = {result} ist der Flächeninhalt des Dreiecks");
                    Console.WriteLine($"Um den Umfang des Dreiecks berechnen zu können brauchen wir mehr Angaben");
                    break;
                case Operator.Circle:
                    Console.WriteLine($"Bitte bei der ersten Zahl den Radius eingeben. Bei der zweiten Zahl 0 eingeben");
                    result = 3 * (numberInput1 * numberInput1);
                    Console.WriteLine($"3 * ({numberInput1}*{numberInput1}) = {result} ist der Flächeninhalt des Kreises");
                    break;
                case Operator.Rectangle:
                    Console.WriteLine($"Bitte bei der ersten Zahl den Radius eingeben. Bei der zweiten Zahl 0 eingeben");
                    result = 3 * (numberInput1 * numberInput1);
                    Console.WriteLine($"3 * ({numberInput1}*{numberInput1}) = {result} ist der Flächeninhalt des Kreises");
                    break;
            }
            Console.ResetColor();
            Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
            Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
            Console.ReadKey();
            return result;
        }
    }

    public enum Operator
    {
        Add = 1,
        Subtract = 2,
        Multiply = 3,
        Divide = 4,
        Triangle = 5,
        Circle = 6,
        Rectangle = 7,
    }
}
