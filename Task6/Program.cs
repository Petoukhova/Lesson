Console.Clear();
Console.Write("Please, enter the checking number: ");

int n = Convert.ToInt32(Console.ReadLine());

if (n%2 == 0)
    Console.WriteLine("Profit! This number is even!");
else 
    Console.WriteLine("I'm sorry, but your number isn't even...");
