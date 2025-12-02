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

namespace PizzaInterface
{
    public partial class Form2 : Form
    {
        private Pizzeria _pizzeria;
        private Kunde _kunde;
        private int größe;
        Bestellung _bestellung;
        private int _bestellnummer;

        public Form2(Pizzeria Pizzeria, Kunde kunde, int bestellnummer)
        {
            InitializeComponent();
            label1.Text = $"Sie bestellen bei: {Pizzeria.Name}";
            _pizzeria = Pizzeria;
            _kunde = kunde;
            _bestellung = null;
            _bestellnummer = bestellnummer;
            foreach (Pizza pizza in _pizzeria.Speisekarte)
            {
                lb_Pizzaauswahl.Items.Add(pizza.Name);
            }
            foreach (ExtraZutat extra in _pizzeria.ExtraZutatlist)
            {
                lb_extrazutaten.Items.Add($"+ {extra.Name} (+{extra.Preis} €)");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int anzahl = (int)nUD_Mengenauswahl.Value;
            RadioButton ausgewählt = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (lb_Pizzaauswahl.SelectedItem == null)
            {
                MessageBox.Show("Bitte wählen Sie eine Pizza aus der Liste aus.");
                return;
            }
            else if (ausgewählt == null)
            {
                MessageBox.Show("Bitte wählen Sie eine Größe aus.");
                return;
            }
            else if (nUD_Mengenauswahl.Value <= 0)
            {
                MessageBox.Show("Bitte geben Sie eine gültige Menge ein.");
                return;
            }
            else if (nUD_Mengenauswahl.Value >= 100)
            {
                MessageBox.Show("Sie können maximal 99 Pizzen einer Sorte bestellen");
                return;
            }
            else
            {
                if (ausgewählt == radioButton1)
                {
                    größe = 28;
                }
                else if (ausgewählt == radioButton2)
                {
                    größe = 32;
                }
                else if (ausgewählt == radioButton3)
                {
                    größe = 40;
                }

                List<ExtraZutat> ExtraZutaten = new List<ExtraZutat>();

                // alle ausgewählten Indizes durchgehen
                foreach (int index in lb_extrazutaten.SelectedIndices)
                {
                    // hole die ExtraZutat mit demselben Index aus der Pizzeria-Liste
                    ExtraZutat extra = new ExtraZutat(_pizzeria.ExtraZutatlist[index].Name, _pizzeria.ExtraZutatlist[index].Preis);

                    // füge sie zur aktuellen Bestellliste hinzu
                    ExtraZutaten.Add(extra);
                }



                if (_bestellung == null)
                {
                    _bestellung = new Bestellung(new Bestellposition(anzahl, _pizzeria, lb_Pizzaauswahl.SelectedIndex, größe, ExtraZutaten), _pizzeria, _kunde, _bestellnummer);
                }
                else
                {
                    for (int i = 0; i < nUD_Mengenauswahl.Value; i++)
                    {
                        _bestellung.FuegePositionHinzu(lb_Pizzaauswahl.SelectedIndex, größe, ExtraZutaten);
                    }
                }


                listView2.Items.Clear();
                foreach (Bestellposition position in _bestellung.Bestellpositionen)
                {
                    ListViewItem item = new ListViewItem(position.Menge.ToString());
                    item.SubItems.Add(position.Pizza.Name);
                    item.SubItems.Add(position.Größe.ToString());
                    string extrasString = "" + string.Join(", ", position.ExtraZutaten.Select(z => $"{z.Name} ({z.Preis:F2} €)"));
                    item.SubItems.Add(extrasString);
                    item.SubItems.Add($"{position.BerechnePreis()} €");
                    listView2.Items.Add(item);
                }

                double Gesamtpreis = _bestellung.berechnePreis();
                textBox2.Text = $"{Gesamtpreis} €";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_bestellung != null)
            {
                Form form3 = new Form3(_bestellung, _kunde, _pizzeria);
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sie müssen mindestens eine Pizza bestellen");
                return;
            }
        }
    }
}
