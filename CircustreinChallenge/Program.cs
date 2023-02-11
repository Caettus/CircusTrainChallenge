using ClassLibrary;

Train train;

Console.WriteLine("Welcome to the Animal to Wagon Optimization project!");
Console.WriteLine("====================================================");
Console.WriteLine("How many animals do you want");


string input = Console.ReadLine();
int.TryParse(input, out int QuantityAnimals);

train = new Train();
train.GenerateNewAnimals(QuantityAnimals);

var rnd = new Random();
return (Size) rnd.Next(Enum.GetNames(typeof(Size)).Length);

Console.WriteLine(train.TotalAnimals.Count);