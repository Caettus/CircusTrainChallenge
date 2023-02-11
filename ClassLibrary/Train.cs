namespace ClassLibrary;

public class Train
{
    public List<Animal> TotalAnimals = new List<Animal>();
    List<Wagon> wagons = new List<Wagon>();

    
    public void GenerateNewAnimals(int numberofAnimalsToAdd)
    {
        for (int i = 0; i < numberofAnimalsToAdd; i++)
        {
            Size randomSize = (Size)new Random().Next(0, 3);
            Diet randomDiet = (Diet)new Random().Next(0, 3);
            TotalAnimals.Add(new Animal() { size = randomSize, diet = randomDiet});
        }
    }
}