namespace Calculator_mit_ENums
{
    public static class Calculator
    {
        public static double Count { get; set; }

        public static double GetNumberInput(string inputPrompt)
        {
            Console.Write(inputPrompt);
            return double.Parse(Console.ReadLine());
        }

        public static double Calculate(double numberInput1, double numberInput2, Operator op)
        {
            double result = 0;
            Count++;
            Console.ForegroundColor = ConsoleColor.Magenta;
            switch (op)
            {
                case Operator.Add:
                    result = numberInput1 + numberInput2;
                    Console.WriteLine($"\nDas Ergebnis von {numberInput1} + {numberInput2} = {Math.Round(result, 2)}\n");
                    break;
                case Operator.Subtract:
                    result = numberInput1 - numberInput2;
                    Console.WriteLine($"\nDas Ergebnis von {numberInput1} - {numberInput2} = {Math.Round(result, 2)}\n");
                    break;
                case Operator.Multiply:
                    result = numberInput1 * numberInput2;
                    Console.WriteLine($"\nDas Ergebnis von {numberInput1} * {numberInput2} = {Math.Round(result, 2)}\n");
                    break;
                case Operator.Divide:
                    result = numberInput1 / numberInput2;
                    Console.WriteLine($"\nDas Ergebnis von {numberInput1} / {numberInput2} = {Math.Round(result, 2)}\n");
                    break;
                case Operator.Triangle:
                    result = (numberInput1 * numberInput2) / 2;
                    Console.WriteLine($"\n({numberInput1} * {numberInput2}) : 2 = {Math.Round(result, 2)} cm2 ist der Flächeninhalt des Dreiecks\n");
                    result = numberInput1 + numberInput1 + numberInput1;
                    Console.WriteLine($"Der Umfang des (gleichseitigen) Dreiecks beträgt: {Math.Round(result, 2)}cm\n");


                    //double kathete = Math.Sqrt((2*result) / numberInput2);
                    //double umfang = kathete + kathete + numberInput1;
                    //result = umfang;
                    //Console.WriteLine($"Umfang bei einem gleichschenkligen rechtwinkligen Dreieck: {Math.Round(result, 2)}\n");


                    break;
                case Operator.Circle:
                    result = double.Pi * (numberInput1 * numberInput1);
                    Console.WriteLine($"\nPi * ({numberInput1}*{numberInput1}) = {Math.Round(result, 2)}cm2 ist der Flächeninhalt des Kreises\n");
                    result = 2 * numberInput1 * double.Pi;
                    Console.WriteLine($"2 * {numberInput1} * Pi = {Math.Round(result, 2)}cm ist der Umfang des Kreises\n");
                    break;
                case Operator.Rectangle:
                    result = numberInput1 * numberInput2;
                    Console.WriteLine($"\n{numberInput1}*{numberInput2} = {Math.Round(result, 2)} Äpfel/Bananen ist der Flächeninhalt des Rechtecks\n");
                    result = numberInput1 + numberInput2 + numberInput1 + numberInput2;
                    Console.WriteLine($"\n{numberInput1} + {numberInput2} + {numberInput1} + {numberInput2}= {Math.Round(result, 2)} Äpfel/Bananen beträgt der Umfang des Rechtecks\n");
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
