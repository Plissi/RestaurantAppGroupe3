using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modèle.SalleRestauration;
using System;
using System.Collections.Generic;

namespace ModeleTest.SalleRestauration
{
    [TestClass]
    public class MaitreHotelTests
    {
        [TestMethod]
        public void accueillirClient_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var maitreHotel = new MaitreHotel(TODO);
            int nombreClient = 0;

            // Act
            var result = maitreHotel.accueillirClient(
                nombreClient);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void changerPosX_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var maitreHotel = new MaitreHotel(TODO);

            // Act
            var result = maitreHotel.changerPosX();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void changerPosY_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var maitreHotel = new MaitreHotel(TODO);

            // Act
            var result = maitreHotel.changerPosY();

            // Assert
            Assert.Fail();
        }
    }
}
