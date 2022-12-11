Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
Console.Write($"Введите {i + 1} элемент массива: ");
array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите номер куста, перед которым остановился модуль: ");
int k = Convert.ToInt32(Console.ReadLine());

while (k < 1 || k > n)
{
    Console.Write("Введено недопустимое значение куста, попробуйте снова: ");
    k = Convert.ToInt32(Console.ReadLine());
}
int sum = 0;
if (k > 1 && k < n)
    sum = array[k-2] + array[k-1] + array[k];
else if (k==1)
    sum = array[n-1] + array[k-1] + array[k];
else
    {sum = array[k-2] + array[k-1] + array[0];}



Console.Write($"Количество ягод равно: {sum}");
/*
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
string[] input = Console.ReadLine().Split(" ");
for (int i = 0; i < input.Length; i++)
array[i] = int.Parse(input[i].ToString());

int maxSumma = 0;
for (int i = 1; i < array.Length - 1; i++)
{
int sum = array[i - 1] + array[i] + array[i + 1];
if (sum > maxSumma)
maxSumma = sum;
}
if (array[0] + array[1] + array[array.Length - 1] > maxSumma)
maxSumma = array[0] + array[1] + array[array.Length - 1];

if (array[array.Length - 1] + array[array.Length - 2] + array[0] > maxSumma)
maxSumma = array[array.Length - 1] + array[array.Length - 2] + array[0];

Console.WriteLine(maxSumma);
*/