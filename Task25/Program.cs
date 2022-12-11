Console.Clear();
Console.Write("Введите основание: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int s = Convert.ToInt32(Console.ReadLine()), res = n;

for (int i = 2; i <= s; i++)
    res = res * n;

Console.WriteLine(res);


