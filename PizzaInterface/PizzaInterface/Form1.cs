using Pizzabestellungen;

namespace PizzaInterface
{
    public partial class Form1 : Form
    {
        private List<Pizzeria> _pizzerien;
        private List<Kunde> _kunden;
        private int _bestellnummer;
        public Form1(List<Pizzeria> pizzerien, List<Kunde> kunde, int bestellnummer)
        {
            InitializeComponent();
            _pizzerien = pizzerien;
            _kunden = kunde;
            _bestellnummer = bestellnummer;
            foreach (Pizzeria pizzeria in pizzerien)
            {
                cb_Pizzerien.Items.Add(pizzeria.Name);
            }
            foreach (Kunde kunden in kunde)
            {
                cb_kundenNummer.Items.Add(kunden.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((cb_Pizzerien.SelectedIndex >= 0) && (cb_kundenNummer.SelectedIndex >= 0))
            {
                Form form2 = new Form2(_pizzerien[cb_Pizzerien.SelectedIndex], _kunden[cb_kundenNummer.SelectedIndex], _bestellnummer);
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bitte wählen sie eine Pizzeria aus");
                return;
            }
        }

        private void b_bestellhistorie_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(_kunden[cb_kundenNummer.SelectedIndex]);
            form4.Show();
            this.Hide();
        }
    }
}
