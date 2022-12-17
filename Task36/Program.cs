void InputArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1,11);
}

void ReleaseArray (int [] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        count = count + array[i];
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях: {count}");
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
InputArray (array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray (array);
