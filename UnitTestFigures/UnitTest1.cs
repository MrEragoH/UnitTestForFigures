using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CircleAndTriangle;

namespace UnitTestFigures
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CorrectData()
        {
            string Rez = CircleAndTriangle.Figures.Area(15, 8, 17, 5);
            string Correct = @"Площадь круга = 78,5
Площадь треугольника = 60
Треугольник является прямоугольным";
            Assert.AreEqual(Rez,Correct);
        }
        [TestMethod]
        public void NegativeSides()
        {
            string Rez = CircleAndTriangle.Figures.Area(15, -8, -17, 2);
            string Correct = @"Площадь круга = 12,56
Треугольника с заданными сторонами не существует";
            Assert.AreEqual(Rez, Correct);
        }
        [TestMethod]
        public void NegativeRadius()
        {
            string Rez = CircleAndTriangle.Figures.Area(15, 8, 17, -5);
            string Correct = @"Круга с заданным радиусом не существует
Площадь треугольника = 60
Треугольник является прямоугольным";
            Assert.AreEqual(Rez, Correct);
        }
        [TestMethod]
        public void RadiusAreZero()
        {
            string Rez = CircleAndTriangle.Figures.Area(15, 8, 17, 0);
            string Correct = @"Круга с заданным радиусом не существует
Площадь треугольника = 60
Треугольник является прямоугольным";
            Assert.AreEqual(Rez, Correct);
        }
        [TestMethod]
        public void ZeroOneSides()
        {
            string Rez = CircleAndTriangle.Figures.Area(15, 0, 17, 5);
            string Correct = @"Площадь круга = 78,5
Треугольника с заданными сторонами не существует";
            Assert.AreEqual(Rez, Correct);
        }
        [TestMethod]
        public void AllSidesAreZero()
        {
            string Rez = CircleAndTriangle.Figures.Area(0, 0, 0, 5);
            string Correct = @"Площадь круга = 78,5
Треугольника с заданными сторонами не существует";
            Assert.AreEqual(Rez, Correct);
        }
    }
}
