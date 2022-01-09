using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pijaca;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRadSaProdavačima()
        {
            Tržnica trznica = new Tržnica();
            for (int i = 0; i < 11000000; i++)
            {
                trznica.Prodavači.Add(new Prodavač("Ime" + i, "sifra" + i, DateTime.Now.AddMonths(-5), i + 0.1));
            }

            //prvi breakpoint
            int x = 0;

            trznica.RadSaProdavačima(trznica.Prodavači[6500000], "Dodavanje", 1);

            //drugi breakpoint
            int y = 0;

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestTuning1()
        {
            Tržnica trznica = new Tržnica();
            for (int i = 0; i < 11000000; i++)
            {
                trznica.Prodavači.Add(new Prodavač("Ime" + i, "sifra" + i, DateTime.Now.AddMonths(-5), i + 0.1));
            }

            //prvi breakpoint
            int x = 0;

            trznica.RadSaProdavačimaTuning1(trznica.Prodavači[6500000], "Dodavanje", 1);

            //drugi breakpoint
            int y = 0;

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestTuning2()
        {
            Tržnica trznica = new Tržnica();
            for (int i = 0; i < 11000000; i++)
            {
                trznica.Prodavači.Add(new Prodavač("Ime" + i, "sifra" + i, DateTime.Now.AddMonths(-5), i + 0.1));
            }

            //prvi breakpoint
            int x = 0;

            trznica.RadSaProdavačimaTuning2(trznica.Prodavači[6500000], "Dodavanje", 1);

            //drugi breakpoint
            int y = 0;

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestTuning3()
        {
            Tržnica trznica = new Tržnica();
            for (int i = 0; i < 11000000; i++)
            {
                trznica.Prodavači.Add(new Prodavač("Ime" + i, "sifra" + i, DateTime.Now.AddMonths(-5), i + 0.1));
            }

            //prvi breakpoint
            int x = 0;

            trznica.RadSaProdavačimaTuning3(trznica.Prodavači[6500000], "Dodavanje", 1);

            //drugi breakpoint
            int y = 0;

            Assert.IsTrue(true);
        }
        
        [TestMethod]
        public void TestPObuhvatOdluke1()
        {
            Tržnica trznica = new Tržnica();
            Prodavač prodavac = new Prodavač("Ime", "100", DateTime.Now.AddMonths(-2), 100);
            Proizvod kupus = new Proizvod(Namirnica.Povrće, "kupus", 3, new DateTime(2021, 10, 10), 2, false);
            Proizvod paradajz = new Proizvod(Namirnica.Povrće, "paradajz", 3, new DateTime(2021, 8, 8), 2, false);
            Proizvod jabuka = new Proizvod(Namirnica.Voće, "jabuka", 3, new DateTime(2021, 9, 9), 2, false);
            List<Proizvod> proizvodi = new List<Proizvod>() { kupus, paradajz, jabuka };
            List<Proizvod> proizvodiStand = new List<Proizvod>() { kupus, paradajz, jabuka };
            Štand štand = new Štand(prodavac, DateTime.Now.AddMonths(3), proizvodiStand);
            List<int> kolicine = new List<int>() { 1, 2, 3 };
            List<DateTime> rokovi = new List<DateTime>() { new DateTime(2022, 3, 4), new DateTime(2022, 3, 3), new DateTime(2022, 4, 3) };
            bool svi = false;
            trznica.NaručiProizvode(štand, proizvodi, kolicine, rokovi, svi);
            Assert.AreEqual(kupus.OčekivanaKoličina, 1);
            Assert.AreEqual(kupus.DatumOčekivaneKoličine, new DateTime(2022, 3, 4));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPObuhvatOdluke2()
        {
            Tržnica trznica = new Tržnica();
            Prodavač prodavac = new Prodavač("Ime", "100", DateTime.Now.AddMonths(-2), 100);
            Proizvod kupus = new Proizvod(Namirnica.Povrće, "kupus", 3, new DateTime(2021, 10, 10), 2, false);
            Proizvod paradajz = new Proizvod(Namirnica.Povrće, "paradajz", 3, new DateTime(2021, 8, 8), 2, false);
            Proizvod jabuka = new Proizvod(Namirnica.Voće, "jabuka", 3, new DateTime(2021, 9, 9), 2, false);
            List<Proizvod> proizvodi = new List<Proizvod>() { kupus, paradajz, jabuka };
            List<Proizvod> proizvodiStand = new List<Proizvod>() { kupus, paradajz, jabuka };
            Štand štand = new Štand(prodavac, DateTime.Now.AddMonths(3), proizvodiStand);
            List<int> kolicine = new List<int>() { 1, 2 };
            List<DateTime> rokovi = new List<DateTime>() { new DateTime(2022, 3, 4), new DateTime(2022, 3, 3), new DateTime(2022, 4, 3) };
            bool svi = false;
            trznica.NaručiProizvode(štand, proizvodi, kolicine, rokovi, svi);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPObuhvatOdluke3()
        {
            Tržnica trznica = new Tržnica();
            Prodavač prodavac = new Prodavač("Ime", "100", DateTime.Now.AddMonths(-2), 100);
            Proizvod kupus = new Proizvod(Namirnica.Povrće, "kupus", 3, new DateTime(2021, 10, 10), 2, false);
            Proizvod paradajz = new Proizvod(Namirnica.Povrće, "paradajz", 3, new DateTime(2021, 8, 8), 2, false);
            Proizvod jabuka = new Proizvod(Namirnica.Voće, "jabuka", 3, new DateTime(2021, 9, 9), 2, false);
            List<Proizvod> proizvodi = new List<Proizvod>() { kupus, paradajz, jabuka };
            List<Proizvod> proizvodiStand = new List<Proizvod>() { kupus, paradajz, jabuka };
            Štand štand = new Štand(prodavac, DateTime.Now.AddMonths(3), proizvodiStand);
            List<int> kolicine = new List<int>() { 1, 2, 3 };
            List<DateTime> rokovi = new List<DateTime>() { new DateTime(2022, 3, 4), new DateTime(2022, 3, 3) };
            bool svi = false;
            trznica.NaručiProizvode(štand, proizvodi, kolicine, rokovi, svi);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPObuhvatOdluke4()
        {
            Tržnica trznica = new Tržnica();
            Prodavač prodavac = new Prodavač("Ime", "100", DateTime.Now.AddMonths(-2), 100);
            Proizvod kupus = new Proizvod(Namirnica.Povrće, "kupus", 3, new DateTime(2021, 10, 10), 2, false);
            Proizvod paradajz = new Proizvod(Namirnica.Povrće, "paradajz", 3, new DateTime(2021, 8, 8), 2, false);
            Proizvod jabuka = new Proizvod(Namirnica.Voće, "jabuka", 3, new DateTime(2021, 9, 9), 2, false);
            List<Proizvod> proizvodi = new List<Proizvod>() { kupus, paradajz, jabuka };
            List<Proizvod> proizvodiStand = new List<Proizvod>() { paradajz, jabuka };
            Štand štand = new Štand(prodavac, DateTime.Now.AddMonths(3), proizvodiStand);
            List<int> kolicine = new List<int>() { 1, 2, 3 };
            List<DateTime> rokovi = new List<DateTime>() { new DateTime(2022, 3, 4), new DateTime(2022, 3, 3), new DateTime(2022, 4, 3) };
            bool svi = false;
            trznica.NaručiProizvode(štand, proizvodi, kolicine, rokovi, svi);
        }

        [TestMethod]
        public void TestPObuhvatOdluke5()
        {
            Tržnica trznica = new Tržnica();
            Prodavač prodavac = new Prodavač("Ime", "100", DateTime.Now.AddMonths(-2), 100);
            Proizvod kupus = new Proizvod(Namirnica.Povrće, "kupus", 3, new DateTime(2021, 10, 10), 2, false);
            Proizvod paradajz = new Proizvod(Namirnica.Povrće, "paradajz", 3, new DateTime(2021, 8, 8), 2, false);
            Proizvod jabuka = new Proizvod(Namirnica.Voće, "jabuka", 3, new DateTime(2021, 9, 9), 2, false);
            List<Proizvod> proizvodi = new List<Proizvod>() { kupus, paradajz, jabuka };
            List<Proizvod> proizvodiStand = new List<Proizvod>() { kupus, paradajz, jabuka };
            Štand štand = new Štand(prodavac, DateTime.Now.AddMonths(3), proizvodiStand);
            List<int> kolicine = new List<int>() { 1, 2, 3 };
            List<DateTime> rokovi = new List<DateTime>() { new DateTime(2022, 3, 4), new DateTime(2022, 3, 3), new DateTime(2022, 4, 3) };
            bool svi = true;
            trznica.NaručiProizvode(štand, proizvodi, kolicine, rokovi, svi);
            Assert.AreEqual(kupus.OčekivanaKoličina, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNaruciProizvode1()
        {
            Tržnica trznica = new Tržnica();
            List<Proizvod> proizvodi = new List<Proizvod>() { new Proizvod(Namirnica.Voće, "jabuka", 5, DateTime.Now, 1.5, true) };
            List<int> kolicine = new List<int>();
            List<DateTime> rokovi = new List<DateTime>();

            trznica.NaručiProizvode(null, proizvodi, kolicine, rokovi);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNaruciProizvode2()
        {
            Tržnica trznica = new Tržnica();
            List<Proizvod> proizvodi = new List<Proizvod>() { new Proizvod(Namirnica.Voće, "jabuka", 5, DateTime.Now, 1.5, true) };
            Štand stand = new Štand(new Prodavač("ime", "123", DateTime.Now.AddDays(-40), 0), DateTime.Now, proizvodi);
            List<int> kolicine = new List<int>() { 1 };
            List<DateTime> rokovi = new List<DateTime>() { DateTime.Now.AddDays(10) };

            List<Proizvod> proizvodi2 = new List<Proizvod>() { new Proizvod(Namirnica.Voće, "narandza", 5, DateTime.Now, 1.5, false) };

            trznica.NaručiProizvode(stand, proizvodi2, kolicine, rokovi);
        }

        [TestMethod]
        public void TestNaruciProizvode3()
        {
            Tržnica trznica = new Tržnica();
            List<Proizvod> proizvodi = new List<Proizvod>() { new Proizvod(Namirnica.Voće, "jabuka", 5, DateTime.Now, 1.5, true) };
            Štand stand = new Štand(new Prodavač("ime", "123", DateTime.Now.AddDays(-40), 0), DateTime.Now, proizvodi);
            List<int> kolicine = new List<int>() { 4 };
            List<DateTime> rokovi = new List<DateTime>() { DateTime.Now.AddDays(10) };

            trznica.NaručiProizvode(stand, proizvodi, kolicine, rokovi);

            Assert.AreEqual(stand.Proizvodi[0].OčekivanaKoličina, kolicine[0]);
        }

        [TestMethod]
        public void TestNaruciProizvode4()
        {
            Tržnica trznica = new Tržnica();
            List<Proizvod> proizvodi = new List<Proizvod>() { new Proizvod(Namirnica.Voće, "jabuka", 5, DateTime.Now, 1.5, true) };
            Štand stand = new Štand(new Prodavač("ime", "123", DateTime.Now.AddDays(-40), 0), DateTime.Now, proizvodi);
            List<int> kolicine = new List<int>() { 4, 2 };
            List<DateTime> rokovi = new List<DateTime>() { DateTime.Now.AddDays(10), DateTime.Now.AddDays(15) };

            proizvodi.Add(new Proizvod(Namirnica.Voće, "narandza", 5, DateTime.Now, 1.5, true));
            trznica.NaručiProizvode(stand, proizvodi, kolicine, rokovi, true);

            //samim time sto nemamo bacen izuzetak znamo da if nije ispunjen ali ipak cemo izvrsiti assert
            Assert.AreNotEqual(stand.Proizvodi[0].OčekivanaKoličina, kolicine[0]);
        }

        [TestMethod]
        public void TestPObuhvatPetlji1()
        {
            Tržnica trznica = new Tržnica();
            Prodavač prodavac = new Prodavač("Prodavac", "100", DateTime.Now.AddMonths(-3), 1000);

            Proizvod paprika = new Proizvod(Namirnica.Povrće, "paprika", 3, new DateTime(2021, 10, 10), 2, false);
            Proizvod mrkva = new Proizvod(Namirnica.Povrće, "mrkva", 3, new DateTime(2021, 8, 8), 2, false);
            Proizvod jagoda = new Proizvod(Namirnica.Voće, "jagoda", 3, new DateTime(2021, 9, 9), 2, false);

            List<Proizvod> proizvodi = new List<Proizvod>() { paprika, mrkva, jagoda };
            List<Proizvod> proizvodiStand = new List<Proizvod>() { paprika, mrkva, jagoda };
            Štand štand = new Štand(prodavac, DateTime.Now.AddMonths(3), proizvodiStand);

            List<int> kolicine = new List<int>() { 1, 2, 3 };
            List<DateTime> rokovi = new List<DateTime>() { new DateTime(2022, 3, 4), new DateTime(2022, 3, 3), new DateTime(2022, 4, 3) };
            bool svi = false;

            trznica.NaručiProizvode(štand, proizvodi, kolicine, rokovi, svi);
            Assert.AreEqual(paprika.OčekivanaKoličina, 1);
            Assert.AreEqual(paprika.DatumOčekivaneKoličine, new DateTime(2022, 3, 4));
        }
    }
}
