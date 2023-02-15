namespace ClassLibrary;

public class Wagon
{
    public int Size { get; set; } = 10;
    public List<Animal> WagonAnimals { get; set; } = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        if (Size >= (int)animal.Size)
        {
            WagonAnimals.Add(animal);
            Size -= (int)animal.Size;
        }
    }

    public bool TryToAddAnimal(Animal animal)
    {
        if (Size >= (int)animal.Size)
        {
            // WagonAnimals.Add(animal);
            
            if (animal.Diet == Diet.Carnivore)
            {
                return false;
            }
        }
        return false;
    }

    public bool CheckIfRuzie(Animal animal)
    {
        if (animal.Diet == Diet.Carnivore && animal.Size == ClassLibrary.Size.Large)
        {
            return true;
        }
        else if (Animal.SmallHerbivore == true && WagonAnimals.Contains(Animal.Carnivore))
        {
            return true;
        }
        
    }
    
    
    //TODO: Size moet 10 blijven, size is 10 min 
    //TODO: 
}