﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalculatorMachine;
using NUnit.Framework;

namespace CalculatorUnitTest
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator calculator;

        [SetUp]
        public void init()
        {
            calculator = new Calculator();
        }

        [Test]
        public void PenambahanTest()
        {
            Assert.AreEqual(5, calculator.Penambahan(2, 3));
        }

        [Test]
        public void PenguranganTest()
        {
            Assert.AreEqual(4, calculator.Pengurangan(7, 3));
        }

        [Test]
        public void PerkalianTest()
        {
            Assert.AreEqual(10, calculator.Perkalian(5, 2));
        }

        [Test]
        public void PembagianTest()
        {
            Assert.AreEqual(3, calculator.Pembagian(6, 2));
        }
    }
}
