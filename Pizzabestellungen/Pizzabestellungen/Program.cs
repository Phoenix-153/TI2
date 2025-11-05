namespace Pizzabestellungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza margherita = new Pizza("Margherita", 7.90);
            Pizza salami = new Pizza("Salami", 8.90);
            Pizza Funghi = new Pizza("Funghi", 8.90);
            Pizzeria pizzeria = new Pizzeria("DaFranco", 3);
            pizzeria.Speisekarte[0] = margherita;
            pizzeria.Speisekarte[1] = salami;
            pizzeria.Speisekarte[2] = Funghi;
            Kunde kunde = new Kunde(4711);
            Bestellung testbestellung = new Bestellung(new Bestellposition(2, pizzeria, 1), pizzeria, kunde);
            testbestellung.fuegePositionHinzu(2);
            string rechnung = testbestellung.druckeBestellung();
            Console.WriteLine(rechnung);
        }
    }
}
