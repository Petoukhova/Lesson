void InputArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1,20);
}

void ReleaseArray (int [] array)
{
    for (int i = 0; i < array.Length /2 + array.Length%2; i++)
    Console.Write($"{array [i] * array [array.Length-1-i]} ");
    
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
InputArray (array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray (array);