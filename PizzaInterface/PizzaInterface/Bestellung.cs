using MySql.Data.MySqlClient;
using PizzaInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Pizzabestellungen
{
    public class Bestellung
    {
        private List<Bestellposition> _bestellpositionen;
        private Pizzeria _pizzeria;
        private Kunde _kunde;
        private int _bestellnummer;
        private DateTime _todayDate = DateTime.Today;

        public Bestellung(Bestellposition bestellposition, Pizzeria pizzeria, Kunde kunde, int bestellnummer)
        {
            _bestellpositionen = new List<Bestellposition>();
            _bestellpositionen.Add(bestellposition);
            this._pizzeria = pizzeria;
            this._kunde = kunde;
            this._bestellnummer = bestellnummer;
        }

        public void FuegePositionHinzu(int pizzaNummer, int größe, List<ExtraZutat>? extras = null)
        {
            // Prüfen, ob diese Kombination schon existiert (Pizza, Größe, Extras identisch)
            var bp = _bestellpositionen.FirstOrDefault(
                existierendeBestellposition =>
                    existierendeBestellposition.Pizza == _pizzeria.Speisekarte[pizzaNummer] &&
                    existierendeBestellposition.Größe == größe &&
                    GleicheExtras(existierendeBestellposition.ExtraZutaten, extras)
            );
            if (bp != null)
            {
                bp.Menge++; 
            }
            else
            {
                Bestellposition neueBestellposition = new Bestellposition(1, _pizzeria, pizzaNummer, größe, extras);
                _bestellpositionen.Add(neueBestellposition);
            }
        }
        // Hilfsmethode zum Vergleichen der Extras
        private bool GleicheExtras(List<ExtraZutat> a, List<ExtraZutat> b)
        {
            if(a.Count != b.Count)
            {
                return false;
            }
            for(int i =0; i<a.Count; i++)
            {
                if (a[i].Name != b[i].Name)
                {
                    return false;
                }
            }
            return true;
        }


        public double berechnePreis()
        {
            double gesamtpreis = 0;
            // Prüfen ob es Bestellpositionen gibt
            if (_bestellpositionen == null || _bestellpositionen.Count == 0)
                return 0;

            foreach (Bestellposition position in _bestellpositionen)
            {
                if (position != null)
                {
                    gesamtpreis += position.BerechnePreis();
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
                gesamtpreis = preis * 0.88;
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
            double preis = Math.Round(berechnePreis(), 2);
            string pizzeriaName = _pizzeria.Name;
            string rechnung = "Der Kunde mit Nr. " + kundennummer + " hat für: " + preis + " Euro bestellt bei der Pizzeria " + pizzeriaName + ":\n";
            return rechnung;
        }
        public List<Bestellposition> Bestellpositionen
        {
            get => _bestellpositionen;
            set
            {
            }
        }
        public void übertageBestellungInDatenbank(string Rabattcode = null)
        {
            const string connectorstring = "Server=localhost;Database=pizzashop_kim;Uid=root;Pwd=Salvare.1539;";

            using (var connection = new MySqlConnection(connectorstring))
            {
                // Datenbank-Kommando zusammenbauen
                MySqlCommand command = connection.CreateCommand();
                foreach (Bestellposition position in _bestellpositionen)
                {
                    int BNR = _bestellnummer;
                    int PNR = position.Pizza.PNR;
                    int menge = position.Menge;
                    string datumString = $"'{_todayDate.ToString("yyyy-MM-dd")}'";
                    MessageBox.Show(datumString);
                    if (Rabattcode == null)
                    {
                        Rabattcode = "NULL";
                    }
                    else
                    {
                        Rabattcode = $"'{Rabattcode}'";
                    }

                    command.CommandText = $"INSERT INTO Bestellliste (BNR, PNR, Anzahl) VALUES ({BNR},{PNR},{menge});" +
                        $"INSERT INTO Bestellungen (BNR,KNR,Datum,RABATT) VALUES ({BNR},{_kunde.Kundennr},{datumString},{Rabattcode})";
                    MessageBox.Show(command.CommandText);
                    command.CommandType = CommandType.Text;
                    try
                    {
                        connection.Open(); // Verbindung öffnen
                        command.ExecuteNonQuery(); // SQL-Befehl ausführen
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}