using ClassLibrary;

Animal animal;
Train train;

Console.WriteLine("Welcome to the Animal to Wagon Optimization project!");
Console.WriteLine("====================================================");
Console.WriteLine("How many animals do you want");


string input = Console.ReadLine();
int.TryParse(input, out int QuantityAnimals);

train = new Train();
train.GenerateNewAnimals(QuantityAnimals);

train.SortAnimalList();

foreach (Animal animaL in train.MAIN)
{
    Console.WriteLine("{0} - {1}", animaL.Diet, animaL.Size);
}