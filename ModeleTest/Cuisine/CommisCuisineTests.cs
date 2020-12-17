using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modèle.Cuisine;

namespace ModeleTest.Cuisine
{
    [TestClass]
    public class CommisCuisineTests
    {
        [TestMethod]
        public void changerPosX_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var commisCuisine = new CommisCuisine();

            // Act
            var result = commisCuisine.changerPosX();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void changerPosY_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var commisCuisine = new CommisCuisine();

            // Act
            var result = commisCuisine.changerPosY();

            // Assert
            Assert.Fail();
        }
    }
}
