namespace ClassLibrary;

public class Train
{
    private List<Animal> TotalAnimals = new List<Animal>();
    private List<Animal> TempAnimalsList = new List<Animal>();
    public List<Animal> OrderedAnimals = new List<Animal>();
    public List<Wagon> wagons = new List<Wagon>();

    private Wagon wagon;
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
        TempAnimalsList = TotalAnimals.OrderByDescending(Animal => Animal.Size).ToList();
        OrderedAnimals = TempAnimalsList.OrderBy(Animal => Animal.Diet).ToList();
    }

    
}