// This script will work only for positive number
// For negative number need to turn over condition
// The best way is to use the number module, but I don't know this operator for this language


Console.Clear();
Console.WriteLine("Please, enter the number");

int n = Convert.ToInt32(Console.ReadLine());

int i = -n;

while (i <= n)
{
   Console.Write($"{i} "); 
   i++;
}
