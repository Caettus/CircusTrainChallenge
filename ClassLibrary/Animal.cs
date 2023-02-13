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

}