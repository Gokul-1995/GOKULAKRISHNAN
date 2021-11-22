﻿using Calculator;
using NUnit.Framework;

namespace NunitTestng
{
    public class Tests
    {
        CalcMethod c1;
        [SetUp]
        public void Setup()
        {
            c1 = new CalcMethod();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(c1.Addition(2, 5), 7);
        }
        [Test]
        public void TestMultipication()
        {
            Assert.AreEqual(c1.Multipication(2, 4), 8);
        }
    }
}