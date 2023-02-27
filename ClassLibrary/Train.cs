using System.Transactions;

namespace ClassLibrary;

public class Train
{
    public List<Animal> TotalAnimals = new List<Animal>();
    private List<Animal> TempAnimalsList = new List<Animal>();
    public List<Animal> OrderedAnimals = new List<Animal>();
    public List<Wagon> wagons = new List<Wagon>();



    Random rnd = new Random();



    public void GenerateNewAnimals(int numberofAnimalsToAdd)
    {
        for (int i = 0; i < numberofAnimalsToAdd; i++)
        {
            var size = Size.Small;
            var diet = Diet.Herbivore;

            int randomSize = rnd.Next(0, 3);
            int randomDiet = rnd.Next(0, 2);

            #region ifStatements

            if (randomSize == 0)
            {
                size = Size.Small;
            }
            else if (randomSize == 1)
            {
                size = Size.Medium;
            }
            else
            {
                size = Size.Large;
            }

            if (randomDiet == 0)
            {
                diet = Diet.Carnivore;
            }
            else
            {
                diet = Diet.Herbivore;
            }

            #endregion

            Animal newanimal = new Animal(diet, size);
            TotalAnimals.Add(newanimal);
        }
    }

    public void SortAnimalList()
    {
        //Dit om scenario een en zes te fixen
        
        int largeHerbivoreCount = 0;
        int mediumHerbivoreCount = 0;
        
        foreach (Animal animal in TotalAnimals){
            if (animal.Diet == Diet.Herbivore) {
                if (animal.Size == Size.Large) {
                    largeHerbivoreCount++;
                } else if (animal.Size == Size.Medium) {
                    mediumHerbivoreCount++;
                }
            }
        }
        
        if (largeHerbivoreCount > mediumHerbivoreCount)
        {
            TempAnimalsList = TotalAnimals.OrderByDescending(Animal => Animal.Size).ToList();
            OrderedAnimals = TempAnimalsList.OrderBy(Animal => Animal.Diet).ToList();
        }
        else if (!TotalAnimals.Contains(Animal.LargeCarnivore) && !TotalAnimals.Contains(Animal.MediumCarnivore))
        {
            TempAnimalsList = TotalAnimals.OrderBy(Animal => Animal.Size).ToList();
            OrderedAnimals = TempAnimalsList.OrderBy(Animal => Animal.Diet).ToList();
        }
        else
        {
            TempAnimalsList = TotalAnimals.OrderByDescending(Animal => Animal.Size).ToList();
            OrderedAnimals = TempAnimalsList.OrderBy(Animal => Animal.Diet).ToList();
        }
    }
    
    public void MakeNewWagon(Animal animal)
    {
        Wagon newWagon = new Wagon(animal);
        wagons.Add(newWagon);
    }

    public void AddAnimalsToWagons()
    {
        foreach (Animal animal in OrderedAnimals)
        {
            bool added = false;
            foreach (Wagon wagon in wagons)
            {
                if (wagon.TryToAddAnimal(animal))
                {
                    added = true;
                    break;
                }
            }
            if (!added)
            {
                MakeNewWagon(animal);
            }
        }
    }
}