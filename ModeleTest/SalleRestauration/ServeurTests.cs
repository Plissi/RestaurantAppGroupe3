using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modèle.SalleRestauration;

namespace ModeleTest.SalleRestauration
{
    [TestClass]
    public class ServeurTests
    {
        [TestMethod]
        public void aider_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var serveur = new Serveur(TODO, TODO);

            // Act
            serveur.aider();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void attendre_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var serveur = new Serveur(TODO, TODO);

            // Act
            serveur.attendre();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void seDeplacer_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var serveur = new Serveur(TODO, TODO);

            // Act
            serveur.seDeplacer();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void changerPosX_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var serveur = new Serveur(TODO, TODO);

            // Act
            var result = serveur.changerPosX();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void changerPosY_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var serveur = new Serveur(TODO, TODO);

            // Act
            var result = serveur.changerPosY();

            // Assert
            Assert.Fail();
        }
    }
}
