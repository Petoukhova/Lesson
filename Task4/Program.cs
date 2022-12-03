Console.Clear();
Console.Write("Please, enter the first number: ");

int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, enter the second number: ");

int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, enter the third number: ");

int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if (n2 > max) 
    max = n2;

if (n3 > max)
    max = n3;

Console.WriteLine($"The biggest number is {max}");