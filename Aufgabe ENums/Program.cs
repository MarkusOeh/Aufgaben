using Calculator_mit_ENums;

double numberInput1 = 0;
double numberInput2 = 0;
double numberInputTriangle1 = 0;
double numberInputTriangle2 = 0;
double result = 0;

    do
    {
        Console.Clear();
        Console.WriteLine("Was willst du rechnen?");
        Console.WriteLine("\t1.Add\n\t2.Subtract\n\t3.Multiply\n\t4.Divide\n\t5.Triangle\n\t6.Circle\n\t7.Rectangle");
        var menuInput = Console.ReadLine();
    double menuInputIndex = double.Parse(menuInput);
    Operator op = (Operator)menuInputIndex;
    switch (op)
    {
        case Operator.Add:
            numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein:\n");
            numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein::\n");
            break;
        case Operator.Subtract:
            numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein:\n");
            numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein:\n");
            break;
        case Operator.Multiply:
            numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein:\n");
            numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein:\n");
            break;
        case Operator.Divide:
            numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein:\n");
            numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein:\n");
            break;
        case Operator.Triangle:
            numberInput1 = Calculator.GetNumberInput("Gebe bitte die Grundseite des Dreiecks ein in cm:\n");
            numberInput2 = Calculator.GetNumberInput("Gebe die Höhe des Dreiecks ein in cm:\n");
            break;
        case Operator.Circle:
            numberInput1 = Calculator.GetNumberInput("Gebe den Radius des Kreises ein in cm:\n");
            break;
        case Operator.Rectangle:
            numberInput1 = Calculator.GetNumberInput("Gebe die Lange Seite des Rechtecks an:\n");
            numberInput2 = Calculator.GetNumberInput("Gebe die Breite Seite des Rechtecks an:\n");
            break;
    }

    switch (op)
    {
        case Operator.Add:
            Calculator.Calculate(numberInput1, numberInput2, Operator.Add);
            break;
        case Operator.Subtract:
            Calculator.Calculate(numberInput1, numberInput2, Operator.Subtract);
            break;
        case Operator.Multiply:
            Calculator.Calculate(numberInput1, numberInput2, Operator.Multiply);
            break;
        case Operator.Divide:
            Calculator.Calculate(numberInput1, numberInput2, Operator.Divide);
            break;
        case Operator.Triangle:
            Calculator.Calculate(numberInput1, numberInput2, Operator.Triangle);
            break;
        case Operator.Circle:
            Calculator.Calculate(numberInput1, numberInput2, Operator.Circle);
            break;
        case Operator.Rectangle:
            Calculator.Calculate(numberInput1, numberInput2, Operator.Rectangle);
            break;
    }
    } while (true);