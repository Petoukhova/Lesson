Console.Clear();
Console.WriteLine("Enter two quater (in arabic style)");

int n = Convert.ToInt32 (Console.ReadLine());

while (n <1 || n >4)
{
Console.WriteLine("Mistake... Try again!");
n = Convert.ToInt32 (Console.ReadLine());
}

if (n == 1)

Console.WriteLine("X > 0; Y > 0");

else if (n == 2)
Console.WriteLine("X < 0; Y > 0");

else if (n == 3)
Console.WriteLine("X < 0; Y < 0");

else if (n == 4)
Console.WriteLine("X > 0; Y < 0");