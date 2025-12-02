using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzabestellungen
{
    public class Kunde
    {
        private int _kundennummer;
        private string _name;
        private string _strasse;
        private int _plz;
        private string _stadt;
        private string _stock;
        public Kunde(int kundennummer, string name, string strasse, int plz, string stadt, string stock)
        {
            this._kundennummer = kundennummer;
            _name = name;
            _strasse = strasse;
            _plz = plz;
            _stadt = stadt;
            _stock = stock;
        }
        public int Kundennr
        {
            get => _kundennummer;
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
        public string Strasse
        {
            get => _strasse;
            set
            {
            }
        }
        public int Plz
        {
            get => _plz;
            set
            {
            }
        }
        public string Stadt
        {
            get => _stadt;
            set
            {
            }
        }
        public string Stock
        {
            get => _stock;
            set
            {
            }
        }
    }
}