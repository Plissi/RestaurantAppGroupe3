using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modèle.Cuisine;

namespace ModeleTest.Cuisine
{
    [TestClass]
    public class ChefCuisineTests
    {
        [TestMethod]
        public void changerPosX_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var chefCuisine = new ChefCuisine();

            // Act
            var result = chefCuisine.changerPosX();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void changerPosY_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var chefCuisine = new ChefCuisine();

            // Act
            var result = chefCuisine.changerPosY();

            // Assert
            Assert.Fail();
        }
    }
}
