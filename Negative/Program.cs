void InputFoto(int[,] foto)
{
    for (int i = 0; i < foto.GetLength(0); i++)
    {
        for (int j = 0; j < foto.GetLength(1); j++)
        {
            foto[i, j] = new Random().Next(0, 2); 
           
            Console.Write($"{foto[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void InputNegative(int[,] negative)
{
    for (int i = 0; i < negative.GetLength(0); i++)
    {
        for (int j = 0; j < negative.GetLength(1); j++)
        {
            negative[i, j] = new Random().Next(0, 2); 
         
            Console.Write($"{negative[i, j]} \t");
        }
        Console.WriteLine();
    }
}



Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] foto = new int[size[0], size[1]];
int[,] negative = new int[size[0], size[1]];
InputFoto(foto);
Console.WriteLine();
InputNegative(negative);

int count = 0;

for (int i = 0; i < negative.GetLength(0); i++)
    {
        for (int j = 0; j < negative.GetLength(1); j++)
        {
            if (foto [i,j] == negative [i,j])
            count++;       
           
        }
        
    }


Console.Write($"Количество ошибочных пикселей: {count}");