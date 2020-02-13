using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PROG2070Assignment1.Tests
{
    [TestFixture]
    public class CircleTest
    {
        Circle circle = new Circle();
        [Test]
        public void GetRadius_ResultIs1()
        {
            Assert.AreEqual(1, circle.GetRadius());
        }
        [Test]
        public void SetRadius_Given2_ResultIs2()
        {
            int radius = 2;
            circle.SetRadius(radius);
            Assert.AreEqual(2, circle.GetRadius());
        }
        [Test]
        public void GetCircumference_ResultIs2()
        {
            double circumference = 0;
            circumference = circle.GetCircumference();
            Assert.AreEqual(2, circumference);
        }

        [Test]
        public void GetArea_ResultIsPI()
        {
            double area = 0;
            area = circle.GetArea();
            Assert.AreEqual(Math.PI, area);
        }
    }
}
