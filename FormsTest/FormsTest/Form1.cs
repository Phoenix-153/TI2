namespace FormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b = "";
            foreach (string s in listBox1.SelectedItems)
            {
                b += "\n * " + s;
            }
            DialogResult r = MessageBox.Show("Siw haben folgenede Biere ausgewählt:" + b, "BIER", MessageBoxButtons.OKCancel);
        }
    }
}
