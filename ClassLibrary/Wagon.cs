namespace ClassLibrary;

public class Wagon
{
    public int Size { get; set; } = 10;
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        if (Size >= (int)animal.Size)
        {
            Animals.Add(animal);
            Size -= (int)animal.Size;
        }
    }
}