namespace ClassLibrary;

public class Animal
{
    
    public Diet diet { get; private set; }

    public Size size { get; private set; }

    public void GenerateNewAnimals(int numberofAnimalsToAdd)
    {
        for (int i = 0; i < numberofAnimalsToAdd; i++)
        {
            Size randomSize = (Size)new Random().Next(0, 3);
            Diet randomDiet = (Diet)new Random().Next(0, 3);
            animals.Add(new Animal() { size = randomSize, diet = randomDiet });
        }
    }
}