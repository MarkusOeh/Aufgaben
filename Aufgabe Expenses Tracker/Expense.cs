using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Expenses_Tracker
{
    internal class Expense
    {
        // Properties
        internal string Name { get; set; }
        internal decimal Price { get; set; }
        internal string Category { get; set; }
        internal DateTime CreatedAt { get; set; }

        public Expense(string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
            CreatedAt = DateTime.Now;
        }
    }
}