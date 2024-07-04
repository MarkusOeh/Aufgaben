namespace Aufgabe_FindSmallestValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------- AUFGABE ----------------------------------
            // Finde den niedrigsten Wert in einem Array arbiträrer Länge, und gebe diesen Zurück.

            List<int> inputValues = new List<int> { 7, 2, 5};
            int smallestValue = 69420;

            int inputValuesLength = inputValues.Count;
            
            if (inputValues[0] < inputValues[1] && inputValues[0] < inputValues[2]) 
            {
                smallestValue = inputValues[0];
            }

            if (inputValues[1] < inputValues[0] && inputValues[1] < inputValues[2])
            {
                smallestValue = inputValues[1];
            }

            if (inputValues[2] < inputValues[1] && inputValues[2] < inputValues[0])
            {
                smallestValue = inputValues[2];
            }

            Console.WriteLine($"FINDE DIE KLEINSTE ZAHL AUS {inputValues[0]}, {inputValues[1]}, {inputValues[2]}\n\n ---->   DIE KLEINSTE ZAHL IST {smallestValue}");


            // ------------------  GOOGLE LÖSUNG ------------------
            //   .Min()  GIBT KLEINSTEN WERT AUS
            //int smallestValue = inputValues.Min();


            // ------------------  EVAS LÖSUNG ------------------
            //int[] numbers = { 10, 2, 356, 334, 1, -5 };

            //int ergebnis = Class1.FindeKleinsteZahl(numbers);

            //Console.WriteLine(ergebnis);


            //internal static int FindeKleinsteZahl(int[] numbers)
            //{
            //    int kleinsteZahl = numbers[0];

            //    foreach (int i in numbers)
            //    {
            //        if (i < kleinsteZahl)
            //        {
            //            kleinsteZahl = i;
            //        }

            //    }
            //    return kleinsteZahl;



        }
    }
}
