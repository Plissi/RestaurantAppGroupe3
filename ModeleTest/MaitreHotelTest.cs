using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modèle.SalleRestauration;

namespace ModeleTest
{
    [TestClass]
    public class MaitreHotelTest
    {
        [TestMethod]
        public void accueillirClientFailingTest()
        {
            Assert.Equals(0, MaitreHotel.accueillirClient(1));
        }
        
        public void accueillirClientPassingTest()
        {
            Assert.Equals(1, MaitreHotel.accueillirClient(1));
        }
        
        public void attribuerTablePassingTest()
        {
            Assert.Equals(1, MaitreHotel.accueillirClient(1));
        }
    }
}
