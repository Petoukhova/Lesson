Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 10); // [1, 10]

Console.WriteLine($"[{string.Join(", ", array)}]");

Console.Write("Введите сдвиг массива: ");
int s = Convert.ToInt32(Console.ReadLine());

int[] newarray = new int [n];

if (s >= 0) 
{
for (int i = 0; i < array.Length; i++)
{
    if ((i + s) < (n -1))
    {
        newarray[i] = array[i+s];
    }
    newarray[i] = array[(i+s)%n];
}
}
else {
    if (s < (-1*array.Length))
    {s = s%array.Length;}
    else {s = s;}
    for (int i = array.Length - 1; i >=0; i--)
{
    if ((i+s) >= 0)
    {
        newarray[i] = array[i+s];
    }
    else 
    {newarray[i] = array[array.Length+i+s];}
   // Console.WriteLine($"Элемент {i+1} - {newarray[i]}");
}
}
Console.WriteLine($"[{string.Join(", ", newarray)}]");