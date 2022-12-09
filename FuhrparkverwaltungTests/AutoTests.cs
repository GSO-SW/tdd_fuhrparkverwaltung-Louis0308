using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fuhrparkverwaltung;

namespace FuhrparkverwaltungTests
{
    [TestClass]
    public class AutoTests
    {
        [TestMethod]
        public void Fahren_SteigertKilometerstand()
        {
            //Arrange
            int kilometerstand = 0;
            Auto a = new Auto(kilometerstand);
            int gefahreneKilometer = 50;

            //Act
            a.Fahren(gefahreneKilometer);

            //Assert
            Assert.AreEqual(50, a.Kilometerstand);
        }
    }
}
