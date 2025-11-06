using Pizzabestellungen;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            Pizza margherita = new Pizza("Margherita", 7.90, true);
            Pizza salami = new Pizza("Salami", 8.90, true);
            Pizza Funghi = new Pizza("Funghi", 8.90, true);
             
            Pizzeria DaFranco = new Pizzeria("DaFranco");
            List<Pizzeria> Pizzerien = new List<Pizzeria>();
            Pizzerien.Add(DaFranco);
            DaFranco.PizzaHinzufuegen(margherita);
            DaFranco.PizzaHinzufuegen(salami);
            DaFranco.PizzaHinzufuegen(Funghi);
            ExtraZutat Pilze = new ExtraZutat("Pilze", 1);
            ExtraZutat Käse = new ExtraZutat("Käse", 1);
            ExtraZutat Knoblauch = new ExtraZutat("Knoblauch", 1);
            DaFranco.ExtraZutatHinzufuegen(Pilze);
            DaFranco.ExtraZutatHinzufuegen(Käse);
            DaFranco.ExtraZutatHinzufuegen(Knoblauch);
            Kunde kunde = new Kunde(4711);
            Application.Run(new Form1(Pizzerien));
        }
    }
}