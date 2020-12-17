using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modèle.Cuisine;

namespace ModeleTest.Cuisine
{
    [TestClass]
    public class ChefPartieTests
    {
        [TestMethod]
        public void changerPosX_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var chefPartie = new ChefPartie();

            // Act
            var result = chefPartie.changerPosX();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void changerPosY_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var chefPartie = new ChefPartie();

            // Act
            var result = chefPartie.changerPosY();

            // Assert
            Assert.Fail();
        }
    }
}
