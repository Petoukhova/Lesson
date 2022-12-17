void InputArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100,1000);
}

void ReleaseArray (int [] array)
{
    int evenNumbers = 0;
    for (int i =0; i < array.Length; i++)
    {
        if (array [i]%2 == 0)
            evenNumbers++;
    }
    Console.WriteLine($"Количество четных элементов массива: {evenNumbers}");
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
InputArray (array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray (array);
