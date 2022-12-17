void InputArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1,100);
}

void ReleaseArray (double [] array)
{
    double max = 0, min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        max = array[i];

        else if (array[i] < min)
        min = array[i];
    }
    Console.WriteLine($"Разность максимального и минимального элементов: {max - min}");
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double [n];
InputArray (array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray (array);
