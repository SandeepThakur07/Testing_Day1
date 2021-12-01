using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Calculator;

namespace Testing_Day1
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void AddMethodtest()
        {
            Calculate cobj = new Calculate();
            int result = cobj.Add(10, 20);
            Assert.That(result, Is.EqualTo(80));
        }
        [Test]
        [TestCase(15,35,50)]
        [TestCase(10,45,55)]
        [TestCase(20,50,70)]
        public void AddMethodtest(int num1,int num2,int expected)
        {
            Calculate cobj = new Calculate();
            int result = cobj.Add(num1, num2);
            Assert.AreEqual(expected, result);
        }
    }
}
