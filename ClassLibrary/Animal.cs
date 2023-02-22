namespace ClassLibrary;

public class Animal
{
    
    public Diet Diet { get; private set; }

    public Size Size { get; private set; }

    public Animal(Diet diet, Size size)
    {
        this.Diet = diet;
        this.Size = size;
    }

    public Animal(Size size, Diet diet)
    {
        this.Diet = diet;
    }

    public static Animal SmallHerbivore
    {
        get => new Animal(Diet.Herbivore, Size.Small);
    }
    public static Animal MediumHerbivore
    {
        get => new Animal(ClassLibrary.Diet.Herbivore, Size.Medium);
    }
    public static Animal LargeHerbivore
    {
        get => new Animal(ClassLibrary.Diet.Herbivore, Size.Large);
    }
    
    public static Animal SmallCarnivore
    {
        get => new Animal(ClassLibrary.Diet.Carnivore, Size.Small);
    }
    public static Animal MediumCarnivore
    {
        get => new Animal(ClassLibrary.Diet.Carnivore, Size.Medium);
    }
    public static Animal LargeCarnivore
    {
        get => new Animal(ClassLibrary.Diet.Carnivore, Size.Large);
    }
}