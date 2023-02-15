using ClassLibrary;

Animal animal;
Train train;

Console.WriteLine("Welcome to the Animal to Wagon Optimization project!");
Console.WriteLine("====================================================");
Console.WriteLine("How many animals do you want");

//Get User Answer
string input = Console.ReadLine();
int.TryParse(input, out int QuantityAnimals);

//Generate and sort animals
train = new Train();
train.GenerateNewAnimals(QuantityAnimals);

train.SortAnimalList();

//Display both the animals and the wagons list
Console.WriteLine("These are the animals you got: ");
foreach (Animal animaL in train.OrderedAnimals)
{
    Console.WriteLine("{0} - {1}", animaL.Diet, animaL.Size);
}

Console.Write("====================================");

train.AddAnimalsToWagons();

for (int i = 0; i < train.wagons.Count; i++)
{
    Console.WriteLine("Wagon " + (i + 1) + ":");
    foreach (Animal _animal in train.wagons[i].WagonAnimals)
    {
        Console.WriteLine("    " + _animal.Diet + " " + _animal.Size);
    }
}