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
        int index;
        Bestellung _bestellung;

        public Form2(Pizzeria Pizzeria, Kunde kunde)
        {
            InitializeComponent();
            label1.Text = $"Sie bestellen bei: {Pizzeria.Name}";
            _pizzeria = Pizzeria;
            _kunde = kunde;
            _bestellung = null;

            foreach (Pizza pizza in _pizzeria.Speisekarte)
            {
                if (pizza.Visible)
                {
                    listBox1.Items.Add(pizza.Name);
                }
            }
            foreach(ExtraZutat extra in _pizzeria.ExtraZutatlist)
            {
                listBox2.Items.Add($"+ {extra.Name} (+{extra.Preis} €)");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            int anzahl = (int)numericUpDown1.Value;
            RadioButton ausgewählt = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Bitte wählen Sie eine Pizza aus der Liste aus.");
                return;
            }
            else if (ausgewählt == null)
            {
                MessageBox.Show("Bitte wählen Sie eine Größe aus.");
                return;
            }
            else if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Bitte geben Sie eine gültige Menge ein.");
                return;
            }
            else if (numericUpDown1.Value >= 100)
            {
                MessageBox.Show("Sie können maximal 99 Pizzen einer Sorte bestellen");
                return;
            }
            else
            {
                if (ausgewählt == radioButton1)
                {
                    index = 1;
                }
                else if (ausgewählt == radioButton2)
                {
                    index = 2;
                }
                else if (ausgewählt == radioButton3)
                {
                    index = 3;
                }


                if (_bestellung == null)
                {
                    _bestellung = new Bestellung(new Bestellposition(anzahl, _pizzeria, (listBox1.SelectedIndex * 4 + index)), _pizzeria, _kunde);
                }
                else
                {
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        _bestellung.fuegePositionHinzu((listBox1.SelectedIndex * 4 + index));

                    }
                }


                listView2.Items.Clear();
                foreach (Bestellposition position in _bestellung.Bestellpositionen)
                {
                    ListViewItem item = new ListViewItem(position.BestellpositionAnzahl.ToString());
                    item.SubItems.Add(position.Pizza.Name);
                    item.SubItems.Add($"{position.Pizza.Preis} €");
                    listView2.Items.Add(item);
                }

                double preis = _bestellung.berechnePreis();
                double Gesamtpreis = Bestellung.berechnePreisMitRabatt(preis, textBox3.Text);
                textBox2.Text = $"{Gesamtpreis} €";

            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
