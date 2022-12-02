Console.Clear();
Console.WriteLine("Please, enter the square of the number");

int q = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please, enter the number to be checked");

int n = Convert.ToInt32(Console.ReadLine());

if (q == n * n)
    Console.WriteLine("Profit!");
else
    Console.WriteLine("Mistake...");