/*
void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = 2 + i;
}


void ReleaseArray(int[] secondArray)
{
for (int i = 0; i < secondArray.Length; i++)
{
secondArray[i] = 2 + i;
}
}

Console.Clear();
Console.Write("Введите элемент: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n-1];
InputArray(array);
int l = n;
int[] secondArray = new int [l];
ReleaseArray(secondArray);

for (int i = 0; i< secondArray.Length; i++)
{
    for (int j =0; j < array.Length; j++)
    {
        if (array[j]/secondArray[i]>1 && array[j]%secondArray[i] == 0)
        array[j]=0;
    }

}
int x1=0, x2=0;

Console.WriteLine(string.Join(" ", array));

for (int k = 0; k < array.Length; k++)
{
    if (array [k] != 0) 
    {
        x1=array[k];
        for (int i = k; i < array.Length; i++)
        {
            if (array[i] == (n - x1) )
                {
                x2 = array[i];
                break;
                }
        }
    }
}

Console.Write($"Разложение на простые числа: {x1}, {x2}");

*/
int n = Convert.ToInt32(Console.ReadLine());
int countDel = 0, i, j, k, m;
for (i = 2; i <= n / 2; i++)
{
    countDel = 0;
    for (j = 2; j <= i / 2; j++)
    {
        if (i % j == 0)
            countDel++;
    }
    if (countDel == 0)
    {
        countDel = 0;
        m = n - i;
        for (k = 2; k <= (m + 1) / 2; k++)
        {
            if (m % k == 0)
                countDel++;
        }
        if (countDel == 0)
        {
            Console.WriteLine($"{i} {m}");
            return;
        }
    }
}