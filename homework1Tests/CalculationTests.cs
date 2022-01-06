using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework1;
using System;

namespace homework1Tests
{
    [TestClass]
    public class CalculationTests
    {
        private const double delta = 0.000001;
        [TestMethod]
        public void TestNoRoots()
        {
            homework1.SqueareRoot sqRoot = new SqueareRoot();
            double[] roots = new double[] { };

            double[] result = (double[])sqRoot.Calculation(1, 0, 1);

            CollectionAssert.AreEqual(roots, result, delta.ToString());
        }

        [TestMethod]
        public void TestTwoRoot()
        {
            homework1.SqueareRoot sqRoot = new SqueareRoot();
            double[] roots = new double[] { 1, -1 };

            double[] result = (double[])sqRoot.Calculation(1, 0, -1);

            CollectionAssert.AreEqual(roots, result, delta.ToString());
        }

        [TestMethod]
        public void TestOneRoots()
        {
            homework1.SqueareRoot sqRoot = new SqueareRoot();
            double[] roots = new double[] { -1, -1 };

            double[] result = (double[])sqRoot.Calculation(1, 2, 1);

            CollectionAssert.AreEqual(roots, result, delta.ToString());
        }

        [TestMethod]
        public void TestANotNull()
        {
            homework1.SqueareRoot sqRoot = new SqueareRoot();

            Exception.ReferenceEquals(new ArgumentException("a != 0"), sqRoot.Calculation(1e-6, 0, 0));
        }

        [TestMethod]
        public void TestArgumentsIsNotDouble()
        {
            homework1.SqueareRoot sqRoot = new SqueareRoot();

            Exception.ReferenceEquals(new ArgumentException(), sqRoot.Calculation("a", "b", 0));
        }
    }
}
