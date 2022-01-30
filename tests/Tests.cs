using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using _01_02_02_WineBarrel;

namespace Test.Tests
{
    [TestClass()]
    public class Tests
    {
        [TestMethod()]
        public void TestKonstrktor()
        {
            string expected=string.Empty;
            string actual = "somthing";
            try
            {
                WineBarrel wb = new WineBarrel("Egri leányka", 10);
                 expected = "Egri leányka mennyisége a hordóban 10 liter.\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                wb.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("WineBarrel osztály kivételt dob!");
            }

            Assert.AreEqual(expected, actual, "A WineBarrel->Konstruktor nem tárolja el a paraméterben lévő adatokat vagy a WineBarrel->ToConsole nem megfelően működik.");
        }

        [TestMethod()]
        public void TestKonstrktorNegativLiter()
        {
            string expected = string.Empty;
            string actual = "somthing";
            try
            {
                WineBarrel wb = new WineBarrel("Egri leányka", -10);
                expected = "A hordó üres!\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                wb.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("WineBarrel osztály kivételt dob!");
            }

            Assert.AreEqual(expected, actual, "A WineBarrel->Konstruktor negatív értékű liter esetén helytelenül működik vagy a WineBarrel->ToConsole nem megfelően működik.");
        }

        [TestMethod()]
        public void TestKonstrktorTakeOutWinePossible()
        {
            string expected = string.Empty;
            string actual = "somthing";
            try
            {
                WineBarrel wb = new WineBarrel("Egri leányka", 100);
                wb.takeOutWine(80);
                expected = "Egri leányka mennyisége a hordóban 20 liter.\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                wb.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("WineBarrel osztály kivételt dob!");
            }

            Assert.AreEqual(expected, actual, "A WineBarrel->TakeOutWine metódus amikor lehetséges a bor mennyiség kivétele nem jól működik vagy a WineBarrel->ToConsole nem megfelően működik.");
        }

        [TestMethod()]
        public void TestKonstrktorTakeOutWineNotPossible()
        {
            string expected = string.Empty;
            string actual = "somthing";
            try
            {
                WineBarrel wb = new WineBarrel("Egri leányka", 100);
                wb.takeOutWine(180);
                expected = "Egri leányka mennyisége a hordóban 100 liter.\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                wb.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("WineBarrel osztály kivételt dob!");
            }

            Assert.AreEqual(expected, actual, "A WineBarrel->TakeOutWine metódus amikor a megadott bor mennyiség kivétele nem lehetséges nem jól működik vagy a WineBarrel->ToConsole nem megfelően működik.");
        }

        [TestMethod()]
        public void TestKonstrktorBarrelIsEmpty()
        {
            string expected = string.Empty;
            string actual = "somthing";
            try
            {
                WineBarrel wb = new WineBarrel("Egri leányka", 100);
                wb.takeOutWine(20);
                wb.takeOutWine(80);
                expected = "A hordó üres!\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                wb.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("WineBarrel osztály kivételt dob!");
            }

            Assert.AreEqual(expected, actual, "A WineBarrel->ToConsole metódus amikor az összes bort kivették nem megfelelően működik.");
        }
    }
}