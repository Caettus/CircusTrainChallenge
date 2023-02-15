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
            if (CheckIfRuzie(animal) == false)
            {
                WagonAnimals.Add(animal);
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
        else if (animal == Animal.SmallHerbivore && WagonAnimals.Contains(Animal.Carnivore))
        {
            return true;
        }
        else if (animal == Animal.Carnivore && animal.Size == ClassLibrary.Size.Medium && !WagonAnimals.Contains(Animal.LargeHerbivore))
        {
            return false;
        }
        
        return false;
    }
    
    
    //TODO: Size moet 10 blijven, Ik moet checken of het nieuwe dier  en de opgetelde hoeveelheid aan dieren die al in de wagon zit, of dat samen meer dan 10 is of niet.
    //TODO: 
}