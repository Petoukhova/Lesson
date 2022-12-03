Console.Clear();
Console.WriteLine("Enter two numbers");

int n1 = Convert.ToInt32 (Console.ReadLine());

int n2 = Convert.ToInt32 (Console.ReadLine());

if (n1 % n2 == 0)

Console.WriteLine("Profit!");

else 
Console.WriteLine($"Mistake... {n1 % n2}");