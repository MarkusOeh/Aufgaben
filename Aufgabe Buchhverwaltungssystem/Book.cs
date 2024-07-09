using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Buchhverwaltungssystem
{
    internal class Book
    {
        internal string Title;
        internal string Author;
        internal string PublicationYear;
        internal string ISBN;

        internal void GetDescription(String getdescription) // das gelbe ist eine Methode, eine Aktion die mein Objekt tätigen kann
        {
            Console.WriteLine($"{Title} von {Author}, veröffentlicht im Jahr {PublicationYear}, ISBN {ISBN}");
        }


/* Die Klasse soll die folgenden Eigenschaften (Properties) haben:
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
Denke daran, den Konstruktor korrekt zu implementieren, damit die Eigenschaften beim Erstellen eines Buchobjekts initialisiert werden.*/
    }
}
