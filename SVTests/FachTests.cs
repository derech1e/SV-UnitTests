using Microsoft.VisualStudio.TestTools.UnitTesting;
using SV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV.Tests
{
    /// <summary>
    /// Einfache Tests zum testen von der Klasse Fach
    /// </summary>

    [TestClass()] // Atribute für die Klasse
    public class FachTests
    {
        private readonly Fach ExpectedFach_MathBs = new Fach("Mathematik;Berufsschule");

        [TestMethod()] // Atribute für die Methode
        public void bastelnFIDTest_MathBs()
        {
            Assert.AreEqual(ExpectedFach_MathBs.bastelnFID(), "MathBS");
        }

        [TestMethod()]
        public void speichernTest_MathBs()
        {
            Assert.AreEqual(ExpectedFach_MathBs.speichern(), "INSERT INTO Fach (FID,Bezeichnung) VALUES ('MathBS', 'Mathematik;Berufsschule');");
        }

        [TestMethod()]
        public void bastelnFIDTest_InSyGK()
        {
            Assert.AreEqual(new Fach("Informatik-Systeme;Grundkurs").bastelnFID(), "InSyGK");
        }

        [TestMethod()]
        public void bastelnFIDTest_EnglLK()
        {
            Assert.AreNotEqual(new Fach("Englisch;Leistungskurs").bastelnFID(), "ENGLK");
        }

        [TestMethod()]
        public void bastelnFIDTest_EnglGK()
        {
            Assert.AreEqual(new Fach("Englisch;Grundkurs").bastelnFID(), "ENGGK");
        }
    }
}