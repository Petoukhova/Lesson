Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), sum = 0;
while (n > 0)
{
    sum = sum + n%10;
    n /= 10;
}
Console.WriteLine(sum);