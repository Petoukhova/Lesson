//в данном коде нет проверки на верификацию вводимых дней месяца

Console.Clear();
Console.Write("Введите количество оценок: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите дни месяца (от 1 до 31): ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int countEven = 0, countOther = 0;
string resultEven = String.Empty, resultOther = String.Empty;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 == 0)
    {countEven++;
    resultEven = resultEven + " " + Convert.ToString(array[i]);
    }
    else
    {countOther++;
    resultOther = resultOther + " " + Convert.ToString(array[i]);
    }
}
Console.WriteLine(resultOther);
Console.WriteLine(resultEven);

if (countEven>countOther)
Console.WriteLine("Profit!");
else if (countEven<countOther)
Console.WriteLine("Unfortunately...");
else 
Console.WriteLine("Split!");
