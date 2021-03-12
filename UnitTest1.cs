using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using static System.Math;

namespace aye2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 1;
            double b = 3;
            var c = Class1.Sum(a, b);
            Assert.AreEqual(4, c);
        } //Сумма

        [TestMethod]
        public void TestMethod2()
        {
            double a = 5;
            double b = 1;
            var c = Class1.Difference(a, b);
            Assert.AreEqual(4, c);
        } //Разность
        [TestMethod]
        public void TestMethod3()
        {
            double a = 10;
            double b = 5;
            var c = Class1.Degree(a, b);
            Assert.AreEqual(2, c);
        }//Деление
        [TestMethod]
        public void TestMethod4()
        {
            double a = 10;
            var c = Class1.Square(a);
            Assert.AreEqual(100, c);
        }//Площадь
        [TestMethod]
        public void TestMethod5()
        {
            double a = 10;
            double b = 5;
            var c = Class1.Multiplication(a, b);
            Assert.AreEqual(50, c);
        }//Умножение
        [TestMethod]
        public void TestMethod6()
        {
            double a = 5;
            double b = 2;
            var c = Class1.Stepen(a, b);
            Assert.AreEqual(25, c);
        }//Возведение в степень
        [TestMethod]
        public void TestMethod7()
        {
            double a = 9;
            var c = Class1.Sqrt1(a);
            Assert.AreEqual(3, c);
        }// Квадратный корень
        [TestMethod]
        public void TestMethod8()
        {
            double a = 5.3;
            var c = Class1.Rounding(a);
            Assert.AreEqual(5, c);
        }//Округление
        [TestMethod]
        public void TestMethod9()
        {
            double r = 2;
            var c = Class1.AreaCircle(r);
            Assert.AreEqual(4 * PI, c);
        }//Площадь кр
        [TestMethod]
        public void TestMethod10()
        {
            double a = 10;
            var c = Class1.SquareArea(a);
            Assert.AreEqual(100, c);
        }//Площадь квадрата
    }
}
