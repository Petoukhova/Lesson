void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((new Random().NextDouble() * (10 + 10) - 10), 2); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);
Console.Write("Введите позицию элемента: ");
int[] point = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

if (point[0]>=0 && point[0]<matrix.GetLength(0))
{
    if (point[1]>=0 && point[1]<matrix.GetLength(1))
        Console.WriteLine (matrix [point[0], point[1]]);
    else Console.WriteLine ("Данная позиция в матрице не существует");  
}
