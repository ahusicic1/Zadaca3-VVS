using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pijaca;
using System;

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

    }
}
