using PizzaInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzabestellungen
{
    public class Pizzeria
    {
        private string _name;
        private List<Pizza> _speisekarte;
        private List<ExtraZutat> _extraZutatlist;

        public Pizzeria(string name)
        {
            this._name = name;
            this._speisekarte = new List<Pizza>();
            this._extraZutatlist = new List<ExtraZutat>();
        }
        public void PizzaHinzufuegen(Pizza pizza)
        {
            _speisekarte.Add(pizza);
        }
        public void ExtraZutatHinzufuegen(ExtraZutat extraZutat)
        {
            _extraZutatlist.Add(extraZutat);
        }

        public List<Pizza> Speisekarte
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
        public List<ExtraZutat> ExtraZutatlist
        {
            get => _extraZutatlist;
            set
            {
            }
        }
    }
}