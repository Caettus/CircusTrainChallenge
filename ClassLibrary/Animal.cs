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

    public Animal(Diet diet)
    {
        this.Diet = diet;
    }


    public static Animal SmallHerbivore
    {
        get => new Animal(Diet.Herbivore, Size.Small);
    }

    public static Animal Carnivore
    {
        get => new Animal(ClassLibrary.Diet.Carnivore);
    }

}