using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pijaca;
using System;
using System.Collections.Generic;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {/*
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
        */
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
            List<int> kolicine = new List<int>() { 1, 2};
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
            List<DateTime> rokovi = new List<DateTime>() { new DateTime(2022, 3, 4), new DateTime(2022, 3, 3)};
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
    }
}
