void InputMatrix(int[,] matrix)
{
       int sum = 0; 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 9); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
            if (i == j)
                sum = sum + matrix[i, j];
        }
        Console.WriteLine();
    }
    Console.WriteLine(sum);
}




Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
