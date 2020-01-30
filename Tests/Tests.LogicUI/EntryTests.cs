using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RietRob.Mofeto.Logic.Ui.Models;

namespace Tests.LogicUI
{
    [TestClass]
    public class EntryTests
    {
        private Record _testTarget;
        private DateTime _date;

        [TestInitialize]
        public void TestInitialize()
        {
            _date = new DateTime(2020,01,03);
            _testTarget = new Record(_date, 1.389, 448.10, 23.57, new Car());
        }

        [TestMethod]
        public void CalculateTheTotalAmountInLiter()
        {
            Assert.AreEqual(32.74,Math.Round(_testTarget.TotalPrice,2));
        }

        [TestMethod]
        public void CalculateTheConsumptionOfHundredKilometer()
        {
            Assert.AreEqual(5.26,Math.Round(_testTarget.GetConsumptionForHundredKilometer(),2));
        }

        [TestMethod]
        public void CalculateTheCostsForHundredKilometer()
        {
            Assert.AreEqual(7.31,Math.Round(_testTarget.CostsForHundredKilometer,2));
        }
    }
}
