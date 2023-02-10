namespace ClassLibrary;

public class Train
{
    public List<Animal> TotalAnimals = new List<Animal>();
    List<Wagon> wagons = new List<Wagon>();

    //public Train(List<Animal> totalAnimals, List<Wagon> wagons)
    //{
    //    TotalAnimals = totalAnimals;
    //    this.wagons = wagons;
    //} 

    public Train(List<Animal> totalAnimals) 
    {
        TotalAnimals = totalAnimals;
    }

    public Train() { }

    public void GenerateNewAnimals(int numberofAnimalsToAdd)
    {
        for (int i = 0; i < numberofAnimalsToAdd; i++)
        {
            TotalAnimals.Add(new Animal());
        }
    }
}