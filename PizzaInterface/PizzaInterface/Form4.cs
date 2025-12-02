using MySql.Data.MySqlClient;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PizzaInterface
{
    public partial class Form4 : Form
    {
        private Kunde _kunde;
        public Form4(Kunde kunde)
        {
            InitializeComponent();
            _kunde = kunde;
            listView1.View = View.Details;
            listView1.BeginUpdate();
            // ListView leeren            
            listView1.Items.Clear();
            listView1.Columns.Clear();

            // Verbindungsstring zusammenstellen
            // ACHTUNG: Zugangsdaten hier nur zu Demo-Zwecken im Klartext!
            // In der Praxis bitte sicherer handhaben!

            // Ersetzen Sie die Inhalte von "Database" und "Pwd" durch Ihre eigenen Angaben!
            // Hier ist das SQL-Passwort gemeint.
            const string connectorstring = "Server=localhost;Database=pizzashop_kim;Uid=root;Pwd=Salvare.1539;";


            // Verbindungsaufbau erfolgt am besten in einem using-Block. Dann wird die Verbindung sicher auch wieder freigegeben
            using (var connection = new MySqlConnection(connectorstring))
            {
                // Datenbank-Kommando zusammenbauen
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT BNR, Datum, RABATT FROM Bestellungen WHERE KNR = {_kunde.Kundennr};";
                command.CommandType = CommandType.Text;

                try
                {
                    connection.Open(); // Verbindung öffnen
                    MySqlDataReader reader = command.ExecuteReader(); // SQL-Befehl ausführen

                    // Tabellenüberschriften in die ListView schreiben
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string columnName = reader.GetName(i);
                        listView1.Columns.Add(columnName, listView1.Width / reader.FieldCount, HorizontalAlignment.Left);
                    }

                    // Datensätze auf dem Reader lesen und in ListViewItems schreiben
                    while (reader.Read())
                    {
                        if (reader.FieldCount > 0)
                        {
                            ListViewItem lvi = new ListViewItem(reader[0].ToString());

                            for (int i = 1; i < reader.FieldCount; i++)
                            {
                                lvi.SubItems.Add(reader[i].ToString());
                            }

                            listView1.Items.Add(lvi);
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Console.ReadLine();

            }
            listView1.EndUpdate();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int BNR = Convert.ToInt32(listView1.SelectedItems[0].Text);
                listView2.View = View.Details;
                listView2.BeginUpdate();
                // ListView leeren            
                listView2.Items.Clear();
                listView2.Columns.Clear();

                // Verbindungsstring zusammenstellen
                // ACHTUNG: Zugangsdaten hier nur zu Demo-Zwecken im Klartext!
                // In der Praxis bitte sicherer handhaben!

                // Ersetzen Sie die Inhalte von "Database" und "Pwd" durch Ihre eigenen Angaben!
                // Hier ist das SQL-Passwort gemeint.
                const string connectorstring = "Server=localhost;Database=pizzashop_kim;Uid=root;Pwd=Salvare.1539;";


                // Verbindungsaufbau erfolgt am besten in einem using-Block. Dann wird die Verbindung sicher auch wieder freigegeben
                using (var connection = new MySqlConnection(connectorstring))
                {
                    // Datenbank-Kommando zusammenbauen
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = $"SELECT PIZZEN.PNAME, Bestellliste.Anzahl FROM Bestellliste, PIZZEN WHERE PIZZEN.PNR = Bestellliste.PNR AND Bestellliste.BNR = {BNR};";
                    

                    command.CommandType = CommandType.Text;

                    try
                    {
                        connection.Open(); // Verbindung öffnen
                        MySqlDataReader reader = command.ExecuteReader(); // SQL-Befehl ausführen

                        // Tabellenüberschriften in die ListView schreiben
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            string columnName = reader.GetName(i);
                            listView2.Columns.Add(columnName, listView2.Width / reader.FieldCount, HorizontalAlignment.Left);
                        }

                        // Datensätze auf dem Reader lesen und in ListViewItems schreiben
                        while (reader.Read())
                        {
                            if (reader.FieldCount > 0)
                            {
                                ListViewItem lvi = new ListViewItem(reader[0].ToString());

                                for (int i = 1; i < reader.FieldCount; i++)
                                {
                                    lvi.SubItems.Add(reader[i].ToString());
                                }

                                listView2.Items.Add(lvi);
                            }
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Console.ReadLine();

                }
                listView2.EndUpdate();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
