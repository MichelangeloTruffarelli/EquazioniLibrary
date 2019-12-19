using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class EquazioniTest
    {
        [TestMethod]
        public void TestIsDetermined()
        {
            double a = 3;
            double b = 4;
            bool risposta_aspettata = true;
            bool risposta = Equazioni.IsDetermined(a, b);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        [TestMethod]
        public void TestIsNotDetermined()
        {
            double a = 5;
            double b = 0;
            bool risposta_aspettata = false;
            bool risposta = Equazioni.IsDetermined(a, b);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        [TestMethod]
        public void TestIsInconsided()
        {
            double a = 0;
            double b = 4;
            bool risposta_aspettata = true;
            bool risposta = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        [TestMethod]
        public static void TestIsInconsident1()
        {
            double a = 7;
            double b = 4;
            bool risposta_aspettata = false;
            bool risposta = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        [TestMethod]
        public static void TestIsDegree2()
        {
            double a = 3;
            bool risposta_aspettata = true;
            bool risposta = Equazioni.IsDegree2(a);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        [TestMethod]
        public static void TestIsNotDegree2()
        {
            double a = 8;
            bool risposta_aspettata = false;
            bool risposta = Equazioni.IsDegree2(a);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        [TestMethod]
        public static void TestDelta()
        {
            double a = 4;
            double b = 3;
            double c = 2;
            double risposta_aspettata = -23;
            double risposta = Equazioni.Delta(a, b, c);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
    }
}
