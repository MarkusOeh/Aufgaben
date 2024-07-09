namespace Aufgabenverwaltungssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Szenario: Alice und Bob arbeiten an mehreren Projekten und benötigen ein Aufgabenverwaltungssystem, um den Überblick über ihre Aufgaben zu behalten. Sie brauchen eine Klasse Task, die grundlegende Informationen über eine Aufgabe speichert und mehrere Methoden bietet, um den Status der Aufgabe zu verwalten.
            Hinweis: Diese Aufgabe ist etwas anderst als die vorherigen. Hier bekommt ihr von mir die Program.Main Methode, sowie eine unvollständige Klasse vorgegeben. Eure Aufgabe ist es, ein neues C#-Projekt zu erstellen (Name: "Taskmaster"), die gegebene unvollständige Klasse zu vervollständigen (Eigenschaften, Methoden, Konstruktor) und mit meinem gegebenen Code die Klasse zu Testen.
            Aufgabenstellung:
            Klasse vervollständigen:
            Die Klasse soll die folgenden Eigenschaften (Properties) haben:
            Title (string)
            Description (string)
            DueDate (DateTime)
            IsCompleted (bool)
            Erstelle einen Konstruktor für die Klasse, der die oben genannten Eigenschaften initialisiert.
            Implementiere gegebene Methoden:
            Erstelle eine Methode GetTaskInfo, die eine Beschreibung der Aufgabe im folgenden Format zurückgibt: "Title: {Title}, Beschreibung: {Description}, Fällig bis: {DueDate}, Erledigt: {IsCompleted}"
            Erstelle eine Methode CompleteTask, die den Status der Aufgabe auf erledigt (IsCompleted = true) setzt.
            Erstelle eine Methode ExtendDueDate, die ein neues Fälligkeitsdatum (DateTime) als Parameter erhält und das Fälligkeitsdatum der Aufgabe entsprechend aktualisiert.
            Testen:
            Erstelle mehrere Instanzen der Klasse Task und rufe die Methoden GetTaskInfo, CompleteTask und ExtendDueDate für jede Instanz auf.
            Gib die Ergebnisse in der Konsole aus.
            Gegebener Code: class Program
            {
                static void Main(string[] args)
                {
                    // Erstelle mehrere Aufgabenobjekte
                    Task task1 = new Task("Dokumentation schreiben", "Schreibe die Projektdokumentation bis zum Ende der Woche", new DateTime(2024, 7, 7));
                    Task task2 = new Task("Code-Review durchführen", "Überprüfe den Code des neuen Features", new DateTime(2024, 7, 5));

                    // Rufe die Beschreibungen ab und gib sie aus
                    Console.WriteLine(task1.GetTaskInfo());
                    Console.WriteLine(task2.GetTaskInfo());

                    // Markiere die erste Aufgabe als erledigt
                    task1.CompleteTask();
                    Console.WriteLine(task1.GetTaskInfo());

                    // Verlängere das Fälligkeitsdatum der zweiten Aufgabe
                    task2.ExtendDueDate(new DateTime(2024, 7, 10));
                    Console.WriteLine(task2.GetTaskInfo());
                }
            }
            public class Task
            {
                // Eigenschaften kommen hier hin:

                // Konstruktor soll hier implementiert werden:

                // Beschreibung der Aufgabe
                public string GetTaskInfo()
                {
                }

                // Markierung der Aufgabe als erledigt
                public void CompleteTask()
                {
                }

                // Verlängerung des Fälligkeitsdatums
                public void ExtendDueDate(DateTime newDueDate)
                {
                }
            }*/
        }
    }
}
