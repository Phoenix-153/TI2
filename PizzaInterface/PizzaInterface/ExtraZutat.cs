using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaInterface
{
    public class ExtraZutat
    {
        public string _name;
        public double _preis;

        public ExtraZutat(string name, double preis)
        {
            this._name = name;
            this._preis = Math.Round(preis,2);
        }
        public string Name
        {
            get => _name;
            set
            {
            }
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
