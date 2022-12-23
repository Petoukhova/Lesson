void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void ReleaseMatrix(int[,] matrix)
{
    int t = 0, i = 0;
    while (i < matrix.GetLength(0) / 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            t = matrix [i,j];
            matrix [i,j]=matrix[matrix.GetLength(0)-1-i,j];
            matrix[matrix.GetLength(0)-1-i,j]=t;
        }
        i++;
    }
}


void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}



Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
ReleaseMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);

