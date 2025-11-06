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
            string name = pizza.Name;
            double preis = pizza.Preis;
            _speisekarte.Add(pizza);
            Pizza pizzas = new Pizza(name+" 28cm", Math.Round(preis, 2), false);
            Pizza pizzam = new Pizza(name+" 32cm", Math.Round(preis*1.2,2), false);
            Pizza pizzal = new Pizza(name + " 40cm", Math.Round(preis * 1.5, 2), false);
            _speisekarte.Add(pizzas);
            _speisekarte.Add(pizzam);
            _speisekarte.Add(pizzal);
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