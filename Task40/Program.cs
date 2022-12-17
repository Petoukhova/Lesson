Console.Write("Введите стороны треугольника: ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

if (array[0] < array[1]+array[2] && array[1]< array[0]+array[2] && array[2]<array[0]+array[1])
Console.Write("Да");
else Console.Write("Нет");
