using Pizzabestellungen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzaInterface
{
    public partial class Form3 : Form
    {
        private Bestellung _bestellung;
        private Pizzeria _pizzeria;
        private Kunde _kunde;
        private double _preis;
        public Form3(Bestellung bestellung, Kunde kunde, Pizzeria pizzeria)
        {
            InitializeComponent();
            _bestellung = bestellung;
            _kunde = kunde;
            _pizzeria = pizzeria;
            _preis = _bestellung.berechnePreis();


            lvÜbersicht.Items.Clear();
            foreach (Bestellposition position in _bestellung.Bestellpositionen)
            {
                ListViewItem item = new ListViewItem(position.Menge.ToString());
                item.SubItems.Add(position.Pizza.Name);
                item.SubItems.Add(position.Größe.ToString());
                string extrasString = "" + string.Join(", ", position.ExtraZutaten.Select(z => $"{z.Name} ({z.Preis:F2} €)"));
                item.SubItems.Add(extrasString);
                item.SubItems.Add($"{position.BerechnePreis()} €");
                lvÜbersicht.Items.Add(item);
            }
            tbPreis.Text = $"{_preis} €";
            tbAdresse.Text = $"{_kunde.Strasse}, {_kunde.Plz} {_kunde.Stadt} {_kunde.Stock}";
            tbGesamtpreis.Text = $"{_preis} €";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _bestellung.übertageBestellungInDatenbank(tbRabattcode.Text);
            MessageBox.Show("Vielen Dank für Ihre Bestellung! Ihre Pizza wird in Kürze geliefert.");
            Application.Exit();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double rabattpreis = Bestellung.berechnePreisMitRabatt(_preis, tbRabattcode.Text);
            if (rabattpreis != _preis)
            {
                double rabatt = Math.Round((_preis - rabattpreis),2);
                tbRabattpreis.Text = $"{rabatt} €";
                tbGesamtpreis.Text = $"{rabattpreis} €";
            }
            else
            {
                tbRabattpreis.Text = "0 €";
                tbGesamtpreis.Text = $"{_preis} €";
            }
        }

    }
}
