﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

namespace Aufgabe_Bestellungsabwicklung_Bits_Bytes
{
    abstract class Posten
    {
        public string Name { get; set; }
        public double Preis { get; set; }

        public Posten(string name, double preis)
        {
            Name = name;
            Preis = preis;
        }

        public abstract double BerechnePreis();
    }
}
