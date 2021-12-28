﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pijaca;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTuning()
        {
            Tržnica trznica = new Tržnica();
            for (int i=0; i<5000000; i++)
            {
                trznica.Prodavači.Add(new Prodavač("Ime" + i, "sifra" + i, DateTime.Now.AddMonths(-5), i + 0.1));
            }

            //prvi breakpoint
            int x = 0;

            trznica.RadSaProdavačima(trznica.Prodavači[2500000], "Dodavanje", 1);

            //drugi breakpoint
            int y = 0;

            Assert.IsTrue(true);
        }
    }
}