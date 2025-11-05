using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzabestellungen
{
    public class Bestellung
    {
        private System.Collections.Generic.List<Bestellposition> _bestellpositionen;
        private Pizzeria _pizzeria;
        private Kunde _kunde;

        public Bestellung(Bestellposition pizzen, Pizzeria pizzeria, Kunde kunde)
        {
            _bestellpositionen = new List<Bestellposition>();
            _bestellpositionen.Add(pizzen);
            this._pizzeria = pizzeria;
            this._kunde = kunde;
        }

        public void fuegePositionHinzu(int pizzanummer)
        {
            var bp = _bestellpositionen.FirstOrDefault(exisitierendeBestellposition => exisitierendeBestellposition.Pizza == _pizzeria.Speisekarte[pizzanummer]);
            if (bp != null)
            {
                bp.BestellpositionAnzahl += 1;
                return;
            }
            else {
                Bestellposition neueBestellposition = new Bestellposition(1, _pizzeria, pizzanummer);
                _bestellpositionen.Add(neueBestellposition);
            }
        }

        public double berechnePreis()
        {
            double gesamtpreis = 0;
            // Prüfen ob es Bestellpositionen gibt
            if (_bestellpositionen == null || _bestellpositionen.Count == 0)
                return 0; 
            
            foreach (Bestellposition position in _bestellpositionen)
            {
                if(position != null && position.Pizza != null)
                
                {
                    gesamtpreis += position.Pizza.Preis * position.BestellpositionAnzahl;
                }
            }
            gesamtpreis = Math.Round(gesamtpreis, 2);
            return gesamtpreis;
        }
        public static double berechnePreisMitRabatt(double preis, string rabattCode)
        {
            double gesamtpreis = 0;
            preis = Math.Round(preis, 2);
            if (rabattCode == "TOPOrder" && preis >= 150)
            {
                gesamtpreis = preis * 0.85;
            }
            else if (rabattCode == "60MINUS12" && preis >= 60)
            {
                gesamtpreis = preis *0.88;
            }
            else if (rabattCode == "STUDENT10")
            {
                gesamtpreis = preis * 0.9;
            }
            else
            {
                gesamtpreis = preis;
            }
            gesamtpreis = Math.Round(gesamtpreis, 2);
            return gesamtpreis;
        }

        public string druckeBestellung()
        {
            int kundennummer = _kunde.Kundennr;
            double preis = Math.Round(berechnePreis(),2);
            string pizzeriaName = _pizzeria.Name;
            string rechnung = "Der Kunde mit Nr. " + kundennummer + " hat für: " + preis + " Euro bestellt bei der Pizzeria " + pizzeriaName + ":\n";
            return rechnung;
        }
        
    }
}