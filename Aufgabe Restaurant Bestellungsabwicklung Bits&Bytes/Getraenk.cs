using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Bestellungsabwicklung_Bits_Bytes
{
    class Getraenk : Posten
    {
        public bool Alkoholisch { get; set; }
        public bool HappyHour { get; set; }

        public Getraenk(bool alkoholisch, bool happyhour, string name, double preis)
            : base(name, preis)
        {
            Alkoholisch = alkoholisch;
            HappyHour = happyhour;
        }

        public override double BerechnePreis()
        {
            if (Alkoholisch && HappyHour)
            {
                return Preis * 0.75;
            }
            return Preis;
        }
    }
}
