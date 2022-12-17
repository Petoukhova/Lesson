void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-9, 10); // [-9, 9]
}


string ReleaseArray(int[] array, int number)
{
for (int i = 0; i < array.Length; i++)
{
if (number == array[i])
return "yes";
}
return "no";
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; // {0, 0,....}
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write("Введите число: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReleaseArray(array, k));



/*void InputArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9,10);
}

void ReleaseArray (int [] array)
{
        Console.Write("Введите проверяемый элемент: ");
        int p = Convert.ToInt32(Console.ReadLine());
        for (int i =0; i < array.Length; i++)
    {
        if (array [i] == p)
        {
            Console.WriteLine("Yes");
            return;
        }
        }
        Console.WriteLine("No");
        return;
    }
    

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
InputArray (array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray (array);
*/