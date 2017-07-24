using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace TriangleTest
{
    [TestClass]
    public class TriangleTest1
    {
        [TestMethod]
        public void RectangleArea_3and4and5_6returned()
        {
            // исходные данные
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            // получение значения с помощью тестируемого метода
            Triangle.Triangle tr = new Triangle.Triangle();
            tr.sideA = 3;
            tr.sideB = 4;
            tr.sideC = 5;
            tr.TriangleArea();
            double actual = tr.S;

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }
    }
}
