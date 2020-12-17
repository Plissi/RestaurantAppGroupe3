using Controleur;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Controleur_test
{
    [TestClass]
    public class OriginatorTests
    {
        [TestMethod]
        public void CreateMemento_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var originator = new Originator(TODO);

            // Act
            var result = originator.CreateMemento();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void SetMemento_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var originator = new Originator(TODO);
            Memento memento = null;

            // Act
            originator.SetMemento(
                memento);

            // Assert
            Assert.Fail();
        }
    }
}
