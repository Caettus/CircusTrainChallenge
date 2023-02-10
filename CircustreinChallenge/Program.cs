// See https://aka.ms/new-console-template for more information
int QuantityAnimals;

Console.WriteLine("Welcome to the Animal to Wagon Optimization project!");
Console.WriteLine("====================================================");
Console.WriteLine("How many animals do you want");

string input = Console.ReadLine();
int.TryParse(input, out QuantityAnimals);

