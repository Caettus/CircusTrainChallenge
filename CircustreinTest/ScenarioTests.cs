using ClassLibrary;

namespace CircustreinTest
{
    [TestClass]
    public class ScenarioTests
    {
        private Train train;

        [TestMethod]
        public void ScenarioOne()
        {
            // Arrange
            train = new Train();
            train.GenerateNewAnimals(4);
            train.SortAnimalList();

            // Act
            train.AddAnimalsToWagons();

            // Assert
            Assert.AreEqual(2, train.wagons.Count);
        }

        [TestMethod]
        public void ScenarioTwo()
        {
            // Arrange
            train = new Train();
            train.GenerateNewAnimals(5);
            train.SortAnimalList();

            // Act
            train.AddAnimalsToWagons();

            // Assert
            Assert.AreEqual(2, train.wagons.Count);
        }

        [TestMethod]
        public void ScenarioThree()
        {
            // Arrange
            train = new Train();
            train.GenerateNewAnimals(7);
            train.SortAnimalList();

            // Act
            train.AddAnimalsToWagons();

            // Assert
            Assert.AreEqual(4, train.wagons.Count);
        }

        [TestMethod]
        public void ScenarioFour()
        {
            // Arrange
            train = new Train();
            train.GenerateNewAnimals(10);
            train.SortAnimalList();

            // Act
            train.AddAnimalsToWagons();

            // Assert
            Assert.AreEqual(5, train.wagons.Count);
        }

        [TestMethod]
        public void ScenarioFive()
        {
            // Arrange
            train = new Train();
            train.GenerateNewAnimals(2);
            train.SortAnimalList();

            // Act
            train.AddAnimalsToWagons();

            // Assert
            Assert.AreEqual(2, train.wagons.Count);
        }

        [TestMethod]
        public void ScenarioSix()
        {
            // Arrange
            train = new Train();
            train.GenerateNewAnimals(15);
            train.SortAnimalList();

            // Act
            train.AddAnimalsToWagons();

            // Assert
            Assert.AreEqual(6, train.wagons.Count);
        }

        [TestMethod]
        public void ScenarioSeven()
        {
            // Arrange
            train = new Train();
            train.GenerateNewAnimals(100);
            train.SortAnimalList();

            // Act
            train.AddAnimalsToWagons();

            // Assert
            Assert.AreEqual(13, train.wagons.Count);
        }
    }
}