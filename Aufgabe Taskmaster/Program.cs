namespace Aufgabe_Taskmaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ich erstelle für den Anfang die folgenden 3 Objekte (task1, task2, task3) für unsere Klasse "Task.cs" :
            Task task1 = new Task("Dokumentation schreiben", "Schreibe die Projektdokumentation bis zum Ende der Woche", new DateTime(2024, 7, 7), false);
            Task task2 = new Task("Code-Review durchführen", "Überprüfe den Code des neuen Features", new DateTime(2024, 7, 5), false);
            Task task3 = new Task("Einkaufen gehen", "Lebensmittel kaufen um etwas leckeres zu kochen :)", new DateTime(2024, 7, 9), false);

            do // Hier startet unsere alte ToDo App die für unsere neue Aufgabenstellung angepasst wurde
            {
                Console.Clear();
                Console.WriteLine("Wir haben bereits 3 Tasks für dich erstellt. Was möchtest du tun?");
                Console.WriteLine("\t1. Tasks Beschreibung abrufen\n\t2. Die erste Aufgabe als erledigt markieren\n\t3. Fälligkeitsdatum der zweiten Aufgabe verlängern");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // Tasks mit ihren Beschreibungen ausgeben. Die Methode "GetTaskInfo()" wird an Objekt 1,2 und 3 ausgeführt
                        Console.WriteLine(task1.GetTaskInfo());
                        Console.WriteLine(task2.GetTaskInfo());
                        Console.WriteLine(task3.GetTaskInfo());
                        Console.ReadKey();
                        break;
                    case "2":
                        // Die erste Aufgabe als erledigt markieren. Die Methode "CompleteTask()" setzt bool auf true bei unserem Objekt (später: "...ERLEDIGT: true")
                        task1.CompleteTask();
                        Console.WriteLine(task1.GetTaskInfo());
                        Console.ReadKey();
                        break;
                    case "3":
                        // Fälligkeitsdatum der zweiten Aufgabe verlängern. Methode "ExtendDueDate" wird ausgeführt mit neuem Wert innerhalb für Objekt task2
                        task2.ExtendDueDate(new DateTime(2024, 7, 10));
                        Console.WriteLine(task2.GetTaskInfo());
                        Console.ReadKey();
                        break;
                }
            } while (true);
        }
    }
}
