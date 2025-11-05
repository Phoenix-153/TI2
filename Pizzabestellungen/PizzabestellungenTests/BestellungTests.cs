using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzabestellungen;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzabestellungenTest
{

    [TestClass()]
    public class BestellungTests
    {
        public void setUpBestellung(Pizzeria pizzeria)
        {
            Pizza defaultmargherita = new Pizza("Margherita", 7.90);
            Pizza defaultsalami = new Pizza("Salami", 8.90);
            Pizza defaultFunghi = new Pizza("Funghi", 8.90);
            ;
            pizzeria.Speisekarte[0] = defaultmargherita;
            pizzeria.Speisekarte[1] = defaultsalami;
            pizzeria.Speisekarte[2] = defaultFunghi;

        }

        [TestMethod()]
        public void BerechnePreis1()
        {
            // Arrange
            Pizzeria pizzeria = new Pizzeria("DaFranco", 3);
            setUpBestellung(pizzeria);
            Kunde kunde = new Kunde(4711);
            Bestellung testbestellung = new Bestellung(new Bestellposition(3, pizzeria, 1), pizzeria, kunde);
            double erwarteter_preis = 3 * 7.90;

            // Act
            double preis = testbestellung.berechnePreis();
            // Assert
            Assert.IsTrue((erwarteter_preis - preis) < 0.01);
        }
        [TestMethod()]
        public void BerechnePreis2()
        {
            // Arrange
            Pizzeria pizzeria = new Pizzeria("DaFranco", 3);
            setUpBestellung(pizzeria);
            Kunde kunde = new Kunde(4711);
            Bestellung testbestellung = new Bestellung(new Bestellposition(1, pizzeria, 1), pizzeria, kunde);
            testbestellung.fuegePositionHinzu(2);
            testbestellung.fuegePositionHinzu(2);
            double erwarteter_preis = 7.90 + 8.90 + 8.90;

            // Act
            double preis = testbestellung.berechnePreis();
            // Assert
            Assert.IsTrue((erwarteter_preis - preis) < 0.01);
        }
        [TestMethod()]
        public void BerechnePreis3()
        {
            // Arrange
            Pizzeria pizzeria = new Pizzeria("DaFranco", 3);
            setUpBestellung(pizzeria);
            Kunde kunde = new Kunde(4711);
            Bestellung testbestellung = new Bestellung(new Bestellposition(0, pizzeria, 1), pizzeria, kunde);
            double erwarteter_preis = 0;

            // Act
            double preis = testbestellung.berechnePreis();
            // Assert
            Assert.IsTrue((erwarteter_preis - preis) < 0.01);
        }
        [TestMethod()]
        public void BerechnePreis4()
        {
            // Arrange
            Pizzeria pizzeria = new Pizzeria("DaFranco", 3);
            setUpBestellung(pizzeria);
            Kunde kunde = new Kunde(4711);
            Bestellung testbestellung = new Bestellung(new Bestellposition(1, pizzeria, 4), pizzeria, kunde);
            double erwarteter_preis = 0;

            // Act
            double preis = testbestellung.berechnePreis();
            // Assert
            Assert.IsTrue((erwarteter_preis - preis) < 0.01);
        }

        // Anforderungen:
        // - Wenn der Rabattcode ["STUDENT10", "60MINUS12", "TOPOrder"] ist und die zusätzliche Bedingung erfüllt wird,
        // wird ein Rabatt von [10%, 12%, 15%] auf den Gesamtpreis gewährt.

        // - Wenn der Rabattcode leer oder ungültig ist, wird kein Rabatt angewendet.
        [DataTestMethod()]
        [DataRow(100, "STUDENT10", 90)]
        [DataRow(99, "STUDENT10", 89.1)]
        [DataRow(10, "60MINUS12", 10)]
        [DataRow(59.99999, "60MINUS12", 52.8)]
        [DataRow(59.994, "60MINUS12", 59.99)]
        [DataRow(60, "60MINUS12", 52.8)]
        [DataRow(1000, "60MINUS12", 880)]
        [DataRow(100, "TOPOrder", 100)]
        [DataRow(200, "TOPOrder", 170)]
        [DataRow(200.666, "TOPOrder", 170.57)]
        [DataRow(149.999, "TOPOrder", 127.5)]
        [DataRow(149.999, "10",150)]
        [DataRow(null, "TOPOrder", 0)]


        [DataRow(24.90, "", 24.90)]
        [DataRow(24.90, "STUDENT10", 22.41)]
        [DataRow(24.90, "60MINUS12", 24.90)]
        [DataRow(73.70, "60MINUS12", 64.86)]
        [DataRow(180.10, "60MINUS12", 158.49)]
        [DataRow(180.10, "TOPOrder", 153.09)]
        [DataRow(180.10, "xxxxx", 180.10)]
        [DataRow(150.00, "TOPOrder", 127.50)]
        [DataRow(0.0, "STUDENT10", 0)]
        public void berechnePreisMitRabatt1(double n, String s, double result)
        {
            // Arrange


            // Act
            double preis = Bestellung.berechnePreisMitRabatt(n, s);
            // Assert
            Assert.IsTrue((result - preis) < 0.01);
        }

    }
}