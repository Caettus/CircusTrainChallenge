namespace ClassLibrary;

public class Wagon
{
    public int Size { get; set; } = 10;
    public List<Animal> WagonAnimals { get; set; }

   

    public Wagon(Animal animal) 
    {
        WagonAnimals = new List<Animal> {animal};
    }

    public bool SizeCheck(Animal animal)
    {
        int TotalSize = (int)animal.Size;
        foreach (Animal animal1 in WagonAnimals)
        {
            TotalSize += (int)animal1.Size;
        }
        if (TotalSize <= 10)
        {
            return false;
        }
        else { return true; }
    }


    public bool CheckIfRuzie(Animal animal)
    {

        if (animal.Diet == Diet.Herbivore && animal.Size > this.WagonAnimals[0].Size)
        {
            return false;
        }
        else if (this.WagonAnimals[0].Diet == Diet.Herbivore)
        {
            return false;
        }
        else
        {
            return true;
        }
    }


    public bool TryToAddAnimal(Animal animal)
    {
        if (animal.Diet == Diet.Carnivore)
        {
            return false;
        }
        else if (animal.Diet == Diet.Herbivore)
        {
            if (SizeCheck(animal) == false)
            {
                if (CheckIfRuzie(animal) == false)
                {
                    WagonAnimals.Add(animal);
                    Size -= (int)animal.Size;
                    return true;
                }
                else if (CheckIfRuzie(animal) == true)
                {
                    return false;
                }
            }
            else { return false; }
        }
        return false;
    }


    //TODO: Size moet 10 blijven, Ik moet checken of het nieuwe dier  en de opgetelde hoeveelheid aan dieren die al in de wagon zit, of dat samen meer dan 10 is of niet.
}