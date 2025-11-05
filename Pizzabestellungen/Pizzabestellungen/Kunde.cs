using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzabestellungen
{
    public class Kunde
    {
        private int _kundennummer;

        public Kunde(int kundennummer)
        {
            this._kundennummer = kundennummer;
        }
        public int Kundennr
        {
            get => _kundennummer;
            set
            {
            }
        }
    }
}