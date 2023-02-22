using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CircusTrainLibrary
{
    public class Scenario
    {
        public string Name { get; private set; }
        public Action Selected { get; private set; }

        Train train;

        public Scenario() { }

        public Scenario(string name, Action selected)
        {
            Name = name;
            Selected = selected;
        }

        public void LoadChosenScenario()
        {
            Console.Clear();
            switch (Name)
            {
                case "Scenario 1":
                    ScenarioOne();
                    break;
                case "Scenario 2":
                    ScenarioTwo();
                    break;
                case "Scenario 3":
                    ScenarioThree();
                    break;
                case "Scenario 4":
                    ScenarioFour();
                    break;
                case "Scenario 5":
                    ScenarioFive();
                    break;
                case "Scenario 6":
                    ScenarioSix();
                    break;
                case "Scenario 7":
                    ScenarioSeven();
                    break;
                case "Choose your own amount of animals":
                    Console.ReadLine();
                    break;
            }
        }

        private void ScenarioOne()
        {
            CreateNewAnimal(Size.Small, Diet.Carnivore);
            CreateNewAnimal(Size.Large, Diet.Herbivore);
            CreateNewAnimal(Size.Large, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
        }

        private void ScenarioTwo()
        {
            CreateNewAnimal(Size.Small, Diet.Carnivore);
            CreateNewAnimal(Size.Large, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
            CreateNewAnimal(Size.Small, Diet.Herbivore);
            CreateNewAnimal(Size.Small, Diet.Herbivore);
            CreateNewAnimal(Size.Small, Diet.Herbivore);
            CreateNewAnimal(Size.Small, Diet.Herbivore);
            CreateNewAnimal(Size.Small, Diet.Herbivore);
        }

        private void ScenarioThree()
        {
            CreateNewAnimal(Size.Large, Diet.Carnivore);
            CreateNewAnimal(Size.Medium, Diet.Carnivore);
            CreateNewAnimal(Size.Small, Diet.Carnivore);
            CreateNewAnimal(Size.Large, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
            CreateNewAnimal(Size.Small, Diet.Herbivore);
        }

        private void ScenarioFour()
        {
            CreateNewAnimal(Size.Large, Diet.Carnivore);
            CreateNewAnimal(Size.Medium, Diet.Carnivore);
            CreateNewAnimal(Size.Small, Diet.Carnivore);
            CreateNewAnimal(Size.Small, Diet.Carnivore);
            CreateNewAnimal(Size.Large, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
            CreateNewAnimal(Size.Small, Diet.Herbivore);
        }

        private void ScenarioFive()
        {
            CreateNewAnimal(Size.Small, Diet.Carnivore);
            CreateNewAnimal(Size.Large, Diet.Herbivore);
            CreateNewAnimal(Size.Large, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
            CreateNewAnimal(Size.Small, Diet.Herbivore);
        }

        private void ScenarioSix()
        {
            CreateNewAnimal(Size.Small, Diet.Carnivore);
            CreateNewAnimal(Size.Small, Diet.Carnivore);
            CreateNewAnimal(Size.Small, Diet.Carnivore);
            CreateNewAnimal(Size.Large, Diet.Herbivore);
            CreateNewAnimal(Size.Large, Diet.Herbivore);
            CreateNewAnimal(Size.Large, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
        }

        private void ScenarioSeven()
        {
            CreateNewAnimal(Size.Large, Diet.Carnivore);
            CreateNewAnimal(Size.Large, Diet.Carnivore);
            CreateNewAnimal(Size.Large, Diet.Carnivore);
            CreateNewAnimal(Size.Medium, Diet.Carnivore);
            CreateNewAnimal(Size.Medium, Diet.Carnivore);
            CreateNewAnimal(Size.Medium, Diet.Carnivore);
            CreateNewAnimal(Size.Small, Diet.Carnivore);
            CreateNewAnimal(Size.Small, Diet.Carnivore);
            CreateNewAnimal(Size.Small, Diet.Carnivore);
            CreateNewAnimal(Size.Small, Diet.Carnivore);
            CreateNewAnimal(Size.Small, Diet.Carnivore);
            CreateNewAnimal(Size.Small, Diet.Carnivore);
            CreateNewAnimal(Size.Small, Diet.Carnivore);
            CreateNewAnimal(Size.Large, Diet.Herbivore);
            CreateNewAnimal(Size.Large, Diet.Herbivore);
            CreateNewAnimal(Size.Large, Diet.Herbivore);
            CreateNewAnimal(Size.Large, Diet.Herbivore);
            CreateNewAnimal(Size.Large, Diet.Herbivore);
            CreateNewAnimal(Size.Large, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
            CreateNewAnimal(Size.Medium, Diet.Herbivore);
        }

        public int CreateRandomAmountOfAnimals(int AmountOfAnimals)
        {
            Random random = new Random();
            for (int i = 0; i < AmountOfAnimals; i++)
            {
                var sizeVar = Size.Small;
                int size = random.Next(1, 4);

                var typeVar = Diet.Carnivore;
                int type = random.Next(1, 3);

                if (size == 1)
                {
                    sizeVar = Size.Small;
                }
                else if (size == 2)
                {
                    sizeVar = Size.Medium;
                }
                else if (size == 3)
                {
                    sizeVar = Size.Large;
                }
                if (type == 1)
                {
                    typeVar = Diet.Carnivore;
                }
                else if (type == 2)
                {
                    typeVar = Diet.Herbivore;
                }
                CreateNewAnimal(sizeVar, typeVar);
            }
            return AmountOfAnimals;
        }

        private string CreateNewAnimal(Size size, Diet type)
        {
            
            if (AnimalMayBeCreated(size, type))
            {
                Animal animal = new Animal(size, type);
                train.TotalAnimals.Add(animal);
            }
            else
            {
                return "Don't forget filling in a size AND a type for the animal";
            }
            return "Animal has succesfully been created";
        }

        private bool AnimalMayBeCreated(Size size, Diet type)
        {
            if (size != Size.Small && size != Size.Medium && size != Size.Large || type != Diet.Herbivore && type != Diet.Carnivore)
            {
                return false;
            }
            return true;
        }
    }
}