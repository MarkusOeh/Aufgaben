using Aufgabe_Bestellungsabwicklung_Bits_Bytes;
using System.Net.Sockets;
class Program
{
    static void Main(string[] args)
    {
        Bestellung bestellung = new Bestellung(bitsAndBitesCard: true);

        Getraenk bier = new Getraenk(alkoholisch: true, happyhour: true, name: "Bier", preis: 5.0);
        bestellung.FuegePostenHinzu(bier);

        Essen pizza = new Essen(extragross: true, name: "Pizza", preis: 8.0);
        bestellung.FuegePostenHinzu(pizza);

        double gesamtpreis = bestellung.BerechneBestellung();
        Console.WriteLine($"Gesamtpreis der Bestellung: {gesamtpreis:F2} Euro");
    }
}