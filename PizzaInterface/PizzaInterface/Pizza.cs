using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzabestellungen
{
    
    public class Pizza
    {
        private string _name;
        private double _preis;
        private bool _visible;


        public Pizza(string name, double preis, bool visible)
        {
            this._name = name;
            this._preis = preis; 
            this._visible = visible;
        }

        public double Preis
        {
            get => _preis;
            set
            {
            }
        }
        public string Name
            {
            get => _name;
            set
            {
            }
        }
        public bool Visible
        {
            get => _visible;
            set
            {
            }
        }
    }
}