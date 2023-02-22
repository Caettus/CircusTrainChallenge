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

            train.TotalAnimals.Add(Animal.SmallCarnivore);
            train.TotalAnimals.Add(Animal.LargeHerbivore);
            train.TotalAnimals.Add(Animal.LargeHerbivore);
            train.TotalAnimals.Add(Animal.MediumHerbivore);
            train.TotalAnimals.Add(Animal.MediumHerbivore);
            train.TotalAnimals.Add(Animal.MediumHerbivore);
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
            train.TotalAnimals.Add(Animal.SmallCarnivore);
            train.TotalAnimals.Add(Animal.LargeHerbivore);
            train.TotalAnimals.Add(Animal.MediumHerbivore);
            train.TotalAnimals.Add(Animal.MediumHerbivore);
            train.TotalAnimals.Add(Animal.SmallHerbivore);
            train.TotalAnimals.Add(Animal.SmallHerbivore);
            train.TotalAnimals.Add(Animal.SmallHerbivore);
            train.TotalAnimals.Add(Animal.SmallHerbivore);
            train.TotalAnimals.Add(Animal.SmallHerbivore);
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
            train.TotalAnimals.Add(Animal.SmallCarnivore);
            train.TotalAnimals.Add(Animal.MediumCarnivore);
            train.TotalAnimals.Add(Animal.LargeCarnivore);
            train.TotalAnimals.Add(Animal.SmallHerbivore);
            train.TotalAnimals.Add(Animal.MediumHerbivore);
            train.TotalAnimals.Add(Animal.LargeHerbivore);
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
            train.TotalAnimals.Add(Animal.SmallCarnivore);
            train.TotalAnimals.Add(Animal.SmallCarnivore);
            train.TotalAnimals.Add(Animal.MediumCarnivore);
            train.TotalAnimals.Add(Animal.LargeCarnivore);
            train.TotalAnimals.Add(Animal.SmallHerbivore);
            train.TotalAnimals.Add(Animal.MediumHerbivore);
            train.TotalAnimals.Add(Animal.MediumHerbivore);
            train.TotalAnimals.Add(Animal.MediumHerbivore);
            train.TotalAnimals.Add(Animal.MediumHerbivore);
            train.TotalAnimals.Add(Animal.MediumHerbivore);
            train.TotalAnimals.Add(Animal.LargeHerbivore);
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
            train.TotalAnimals.Add(Animal.SmallCarnivore);
            train.TotalAnimals.Add(Animal.SmallHerbivore);
            train.TotalAnimals.Add(Animal.MediumHerbivore);
            train.TotalAnimals.Add(Animal.LargeHerbivore);
            train.TotalAnimals.Add(Animal.LargeHerbivore);
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
            train.TotalAnimals.Add(Animal.SmallCarnivore);
            train.TotalAnimals.Add(Animal.SmallCarnivore);
            train.TotalAnimals.Add(Animal.SmallCarnivore);
            train.TotalAnimals.Add(Animal.MediumCarnivore);
            train.TotalAnimals.Add(Animal.MediumCarnivore);
            train.TotalAnimals.Add(Animal.LargeCarnivore);
            train.TotalAnimals.Add(Animal.LargeCarnivore);
            train.TotalAnimals.Add(Animal.LargeCarnivore);
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
            train.TotalAnimals.Add(Animal.SmallCarnivore);
            train.TotalAnimals.Add(Animal.SmallCarnivore);
            train.TotalAnimals.Add(Animal.SmallCarnivore);
            train.TotalAnimals.Add(Animal.SmallCarnivore);
            train.TotalAnimals.Add(Animal.SmallCarnivore);
            train.TotalAnimals.Add(Animal.SmallCarnivore);
            train.TotalAnimals.Add(Animal.SmallCarnivore);
            train.TotalAnimals.Add(Animal.MediumCarnivore);
            train.TotalAnimals.Add(Animal.MediumCarnivore);
            train.TotalAnimals.Add(Animal.MediumCarnivore);
            train.TotalAnimals.Add(Animal.LargeCarnivore);
            train.TotalAnimals.Add(Animal.LargeCarnivore);
            train.TotalAnimals.Add(Animal.LargeCarnivore);

            train.TotalAnimals.Add(Animal.MediumHerbivore);
            train.TotalAnimals.Add(Animal.MediumHerbivore);
            train.TotalAnimals.Add(Animal.MediumHerbivore);
            train.TotalAnimals.Add(Animal.MediumHerbivore);
            train.TotalAnimals.Add(Animal.MediumHerbivore);
            train.TotalAnimals.Add(Animal.LargeHerbivore);
            train.TotalAnimals.Add(Animal.LargeHerbivore);
            train.TotalAnimals.Add(Animal.LargeHerbivore);
            train.TotalAnimals.Add(Animal.LargeHerbivore);
            train.TotalAnimals.Add(Animal.LargeHerbivore);
            train.TotalAnimals.Add(Animal.LargeHerbivore);
            train.SortAnimalList();

            // Act
            train.AddAnimalsToWagons();

            // Assert
            Assert.AreEqual(13, train.wagons.Count);
        }
    }
}