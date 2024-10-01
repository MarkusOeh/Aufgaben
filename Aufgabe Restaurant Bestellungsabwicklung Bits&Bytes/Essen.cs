using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Bestellungsabwicklung_Bits_Bytes
{
    class Essen : Posten
    {
        public bool ExtraGross { get; set; }

        public Essen(bool extragross, string name, double preis)
            : base(name, preis)
        {
            ExtraGross = extragross;
        }

        public override double BerechnePreis()
        {
            if (ExtraGross)
            {
                return Preis * 1.2;
            }
            return Preis;
        }
    }
}
