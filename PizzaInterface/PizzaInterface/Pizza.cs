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
        private int _pnr;


        public Pizza(string name, double preis, int pnr)
        {
            this._name = name;
            this._preis = preis;
            _pnr = pnr;
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
        public int PNR
        {
            get => _pnr;
            set
            {
            }
        }
    }
}