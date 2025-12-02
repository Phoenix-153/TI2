using PizzaInterface;
using System;
using System.Collections.Generic;

namespace Pizzabestellungen
{
    public class Bestellposition
    {
        private int _menge;
        private Pizza _pizza;
        private int _größe;
        private List<ExtraZutat> _extraZutaten;

        public Bestellposition(int anzahl, Pizzeria pizzeria, int pizzaIndex, int größe, List<ExtraZutat>? extraZutaten = null)
        {
            // Eingaben prüfen
            if (pizzeria == null)
                throw new ArgumentNullException(nameof(pizzeria));

            if (pizzaIndex < 0 || pizzaIndex >= pizzeria.Speisekarte.Count)
                throw new ArgumentOutOfRangeException(nameof(pizzaIndex), "Ungültiger Pizzaindex.");

            _menge = anzahl;
            _größe = größe;

            // Pizza aus der Speisekarte holen
            _pizza = pizzeria.Speisekarte[pizzaIndex];

            // Wenn keine Extras übergeben wurden → leere Liste anlegen
            _extraZutaten = extraZutaten ?? new List<ExtraZutat>();

        }
        public double BerechnePreis()
        {
            double preismultiplier;
            switch (_größe)
            {
                case 28:
                    preismultiplier = 1;
                    break;
                case 32:
                    preismultiplier = 1.2;
                    break;
                case 49:
                    preismultiplier = 1.5;
                    break;
                default:
                    preismultiplier = 1;
                    break;
            }
            double preis = (_pizza.Preis * preismultiplier + _extraZutaten.Sum(e => e.Preis)) * _menge;
            return preis;
        }
        public Pizza Pizza => _pizza;
        public int Menge
        {
            get => _menge;
            set => _menge = value;
        }

        public int Größe => _größe;
        public List<ExtraZutat> ExtraZutaten => _extraZutaten;
    }
}
