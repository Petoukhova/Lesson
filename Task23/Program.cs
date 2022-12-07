Console.Clear();
Console.WriteLine("Enter number");

int n = Convert.ToInt32(Console.ReadLine());

int i = 1;

for (i=1; i<=n; i++)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
}