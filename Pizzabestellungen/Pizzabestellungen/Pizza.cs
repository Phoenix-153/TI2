using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzabestellungen
{
    
    public class Pizza
    {
        private string Name;
        private double _preis;

        public Pizza(string name, double preis)
        {
            this.Name = name;
            this._preis = preis; 
        }

        public double Preis
        {
            get => _preis;
            set
            {
            }
        }
    }
}