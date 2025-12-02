using Pizzabestellungen;
using MySql.Data.MySqlClient;
using System.Data;

namespace PizzaInterface
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Verbindungsstring zusammenstellen
            // ACHTUNG: Zugangsdaten hier nur zu Demo-Zwecken im Klartext!
            // In der Praxis bitte sicherer handhaben!

            // Ersetzen Sie die Inhalte von "Database" und "Pwd" durch Ihre eigenen Angaben!
            // Hier ist das SQL-Passwort gemeint.
            const string connectorstring = "Server=localhost;Database=pizzashop_kim;Uid=root;Pwd=Salvare.1539;";

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();


            List<Pizza> Pizzen = new List<Pizza>();
            // Verbindungsaufbau erfolgt am besten in einem using-Block. Dann wird die Verbindung sicher auch wieder freigegeben
            using (var connection = new MySqlConnection(connectorstring))
            {
                // Datenbank-Kommando zusammenbauen
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM PIZZEN";
                command.CommandType = CommandType.Text;

                try
                {
                    connection.Open(); // Verbindung öffnen
                    MySqlDataReader reader = command.ExecuteReader(); // SQL-Befehl ausführen

                    // Datensätze auf dem Reader lesen und in ListViewItems schreiben
                    while (reader.Read())
                    {
                        if (reader.FieldCount > 0)
                        {
                                Pizza pizzabuffer = new Pizza( reader[1].ToString(), Convert.ToDouble( reader[2]), Convert.ToInt32(reader[0]));
                                Pizzen.Add(pizzabuffer);
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


            List<Kunde> Kunden = new List<Kunde>();
            // Verbindungsaufbau erfolgt am besten in einem using-Block. Dann wird die Verbindung sicher auch wieder freigegeben
            using (var connection = new MySqlConnection(connectorstring))
            {
                // Datenbank-Kommando zusammenbauen
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Kunden";
                command.CommandType = CommandType.Text;

                try
                {
                    connection.Open(); // Verbindung öffnen
                    MySqlDataReader reader = command.ExecuteReader(); // SQL-Befehl ausführen

                    // Datensätze auf dem Reader lesen und in ListViewItems schreiben
                    while (reader.Read())
                    {
                        if (reader.FieldCount > 0)
                        {
                            Kunde Kunde = new Kunde(
                                Convert.ToInt32(reader[0]),
                                Convert.ToString(reader[1]),
                                Convert.ToString(reader[2]),
                                Convert.ToInt32(reader[3]),
                                Convert.ToString(reader[4]),
                                Convert.ToString(reader[5])
                                );
                            Kunden.Add(Kunde);
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

            int bestellnummer = 0;
            // Verbindungsaufbau erfolgt am besten in einem using-Block. Dann wird die Verbindung sicher auch wieder freigegeben
            using (var connection = new MySqlConnection(connectorstring))
            {
                // Datenbank-Kommando zusammenbauen
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT BNR FROM Bestellliste Order By BNR DESC Limit 1";
                command.CommandType = CommandType.Text;

                try
                {
                    connection.Open(); // Verbindung öffnen
                    MySqlDataReader reader = command.ExecuteReader(); // SQL-Befehl ausführen

                    // Datensätze auf dem Reader lesen und in ListViewItems schreiben
                    while (reader.Read())
                    {
                        if (reader.FieldCount > 0)
                        {
                            bestellnummer = Convert.ToInt32(reader[0]) + 1;
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


            Pizzeria DaFranco = new Pizzeria("DaFranco");
            List<Pizzeria> Pizzerien = new List<Pizzeria>();
            Pizzerien.Add(DaFranco);
            foreach (Pizza pizza in Pizzen)
            {
                DaFranco.PizzaHinzufuegen(pizza);
            }
            ExtraZutat Pilze = new ExtraZutat("Pilze", 1);
            ExtraZutat Käse = new ExtraZutat("Käse", 1);
            ExtraZutat Knoblauch = new ExtraZutat("Knoblauch", 1);
            DaFranco.ExtraZutatHinzufuegen(Pilze);
            DaFranco.ExtraZutatHinzufuegen(Käse);
            DaFranco.ExtraZutatHinzufuegen(Knoblauch);
            Application.Run(new Form1(Pizzerien,Kunden,bestellnummer));
        }
    }
}