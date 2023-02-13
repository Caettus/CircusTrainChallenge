namespace ClassLibrary;

public class Train
{
    public List<Animal> TotalAnimals = new List<Animal>();
    public List<Animal> MAIN = new List<Animal>();
    List<Wagon> wagons = new List<Wagon>();

    Random rnd = new Random();


    public List<Animal> GenerateNewAnimals(int numberofAnimalsToAdd)
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

        return (TotalAnimals);
    }

    public void SortAnimalList()
    {
        List<Animal> TEMP = TotalAnimals.OrderByDescending(Animal => Animal.Size).ToList();
        List<Animal> MAIN = TEMP.OrderByDescending(Animal => Animal.Diet).ToList();
    }
}