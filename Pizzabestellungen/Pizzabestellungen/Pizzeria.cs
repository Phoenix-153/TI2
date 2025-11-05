using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzabestellungen
{
    public class Pizzeria
    {
        private string _name;
        private Pizza[] _speisekarte;

        public Pizzeria(string name, int anzahlPizzen)
        {
            this._name = name;
            this._speisekarte = new Pizza[anzahlPizzen];
        }

        public Pizza[] Speisekarte
        {
            get => _speisekarte;
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
    }
}