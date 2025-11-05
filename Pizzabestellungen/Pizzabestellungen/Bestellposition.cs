using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzabestellungen
{
    public class Bestellposition
    {
        private int _bestellposition;
        private Pizza _pizza; 


        public Bestellposition(int anzahl, Pizzeria pizzeria, int pizzaindex)
        {
            if (pizzaindex < 0 || pizzaindex >= pizzeria.Speisekarte.Length)
            {
                _bestellposition = 0;
                _pizza = null;
                return;
            }
            this._bestellposition = anzahl;
            Pizza[] speisekarte = pizzeria.Speisekarte;
            _pizza = speisekarte[pizzaindex];
        }
        public Pizza Pizza
        {
            get => _pizza;
            set
            {
            }
        }
        public int BestellpositionAnzahl
        {
            get => _bestellposition;
            set
            {
                _bestellposition = value;
            }
        }
    }
}