using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modèle.SalleRestauration;

namespace ModeleTest.SalleRestauration
{
    [TestClass]
    public class ChefRangTests
    {
        [TestMethod]
        public void aider_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var chefRang = new ChefRang(TODO, TODO);

            // Act
            chefRang.aider();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void attendre_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var chefRang = new ChefRang(TODO, TODO);

            // Act
            chefRang.attendre();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void seDeplacer_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var chefRang = new ChefRang(TODO, TODO);

            // Act
            chefRang.seDeplacer();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void changerPosX_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var chefRang = new ChefRang(TODO, TODO);

            // Act
            var result = chefRang.changerPosX();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void changerPosY_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var chefRang = new ChefRang(TODO, TODO);

            // Act
            var result = chefRang.changerPosY();

            // Assert
            Assert.Fail();
        }
    }
}
