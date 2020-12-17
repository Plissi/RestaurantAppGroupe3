using Controleur;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Controleur_test
{
    [TestClass]
    public class MementoTests
    {
        [TestMethod]
        public void GetDate_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var memento = new Memento(TODO);

            // Act
            var result = memento.GetDate();

            // Assert
            Assert.Fail();
        }
    }
}
