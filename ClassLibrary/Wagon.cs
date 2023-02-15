namespace ClassLibrary;

public class Wagon
{
    private Train train;
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

    public void ifAnimalCanBeAdded(Animal animal, Wagon newWagon)
    {
        bool ifAnimalAdded = false;

        foreach (Animal _animal in WagonAnimals)
        {
            if (animal.Diet == Diet.Carnivore && animal.Size == ClassLibrary.Size.Large)
            {
                newWagon.AddAnimal(animal);
                ifAnimalAdded = true;
            }
            else
            {
                return ifAnimalAdded;
            }
        }
    }
    
    public void AddAnimalsToWagons()
    {
        foreach (Animal animal in train.OrderedAnimals)
        {
            bool added = false;
            foreach (Wagon wagon in train.wagons)
            {
                if (wagon.Size >= (int)animal.Size)
                {
                    WagonAnimals.AddAnimal(animal);
                    added = true;
                    break;
                }
            }
            
            if (!added)
            {
                Wagon newWagon = new Wagon();
                newWagon.AddAnimal(animal);
                train.wagons.Add(newWagon);
            }
        }
    }
    
    //1. Vanuit de wagon een dier toevoegen, dus dan voeg ik het dier toe aan WagonAnimals
    //2. Vanuit de wagon kijken of een dier een large carnivoor is, in dat geval stuur automatisch in eigen wagon
    //3. moet ik dan vervolgens voor elke situatie checken?
    //4. 
    
    
}