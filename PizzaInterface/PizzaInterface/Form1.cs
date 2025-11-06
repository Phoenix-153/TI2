using Pizzabestellungen;

namespace PizzaInterface
{
    public partial class Form1 : Form
    {
        private List<Pizzeria> _pizzerien;
        public Form1(List<Pizzeria> pizzerien)
        {
            InitializeComponent();
            _pizzerien = pizzerien;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eingabe = textBox1.Text;
            bool pizzaExists = false;
            Pizzeria pizzeriafound = null;
            foreach (var pizzeria in _pizzerien)
            {
                if (pizzeria.Name == eingabe)
                {
                    pizzeriafound = pizzeria;
                    pizzaExists = true;
                    break;
                }
            }
            if (pizzaExists)
            {
                Form form2 = new Form2(pizzeriafound, new Kunde(1));
                form2.Show();
                this.Hide();
            }
            else { 
                MessageBox.Show("Die angegebene Pizzeria existiert nicht.");
                return;
            }
        }
    }
}
