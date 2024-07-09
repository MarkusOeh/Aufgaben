namespace Aufgabe_Buchhverwaltungssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book();
            book1.Title = "Harry Potter";
            book1.Author = "JK Rowling";
            book1.PublicationYear = "2005";
            book1.ISBN = "3551354014";

            book1.GetDescription(); //funktioniert nicht
            Console.WriteLine($"{book1}"); // gibt aus: Aufgabe_Buchhverwaltungssystem.Book

            /* Szenario: Alice und Bob betreiben eine kleine Bibliothek und wollen ein einfaches Buchverwaltungssystem erstellen. Sie brauchen eine Klasse Book, die grundlegende Informationen über ein Buch speichert und eine Methode, die eine Beschreibung des Buches zurückgibt.
            Aufgabenstellung:
            Klasse erstellen:
            Erstelle eine Klasse Book.
            Die Klasse soll die folgenden Eigenschaften (Properties) haben:
            Title (string)
            Author (string)
            PublicationYear (int)
            ISBN (string)
            Erstelle einen Konstruktor für die Klasse, der die oben genannten Eigenschaften initialisiert.
            Erstelle eine Methode GetDescription, die eine Beschreibung des Buches im folgenden Format zurückgibt: "{Title}" von {Author}, veröffentlicht im Jahr {PublicationYear} (ISBN: {ISBN}).
            Instanzierung und Nutzung:
            Erstelle mehrere Instanzen der Klasse Book und rufe die Methode GetDescription für jede Instanz auf.
            Gib die Beschreibungen in der Konsole aus.
            Hinweise:
            Achte auf die richtige Nutzung von Zugriffmodifizierern (public/private) für die Eigenschaften und Methoden.
            Denke daran, den Konstruktor korrekt zu implementieren, damit die Eigenschaften beim Erstellen eines Buchobjekts initialisiert werden.
            */


        }
    }
}
