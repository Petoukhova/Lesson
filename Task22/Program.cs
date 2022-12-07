Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), i;
for (i = 1; i <= n; i++)
Console.Write($"{i * i} ");