using ClassLibrary;

Animal animal;
Train train;

Console.WriteLine("Welcome to the Animal to Wagon Optimization project!");
Console.WriteLine("====================================================");
Console.WriteLine("How many animals do you want");


string input = Console.ReadLine();
int.TryParse(input, out int QuantityAnimals);

animal = new Animal();
animal.GenerateNewAnimals(QuantityAnimals);

train= new Train();
foreach (var animaL in train.TotalAnimals)
{
    Console.WriteLine($"Size: {animaL.size} Diet: {animaL.diet}");
}
