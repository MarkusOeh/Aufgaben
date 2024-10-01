using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Bestellungsabwicklung_Bits_Bytes
{
    class Bestellung
    {
        public bool BitsAndBitesCard { get; set; }
        public List<Posten> PostenListe { get; set; }

        public Bestellung(bool bitsAndBitesCard)
        {
            BitsAndBitesCard = bitsAndBitesCard;
            PostenListe = new List<Posten>();
        }

        public void FuegePostenHinzu(Posten posten)
        {
            PostenListe.Add(posten);
        }

        public double BerechneBestellung()
        {
            double gesamtbetrag = 0;

            foreach (var posten in PostenListe)
            {
                gesamtbetrag += posten.BerechnePreis();
            }

            if (BitsAndBitesCard)
            {
                gesamtbetrag *= 0.95;
            }

            return gesamtbetrag;
        }
    }
}
