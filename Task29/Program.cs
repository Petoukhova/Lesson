// код работает, но при попытке создать числовой массив путем конвертирования имеющегося выдало ошибку
// Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
//   at Program.<Main>$(String[] args) in D:\CSharp\Lesson1\Task29\Program.cs:line 14//

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите элементы массива: ");
string [] array = Console.ReadLine().Split(", ");
/*
int [] total = new int [array.Length-1];

for (int i = 0; i < array.Length; i++)
    total[i] = int.Parse(array[i]);
*/
Console.WriteLine($"[{string.Join(", ", array)}]");