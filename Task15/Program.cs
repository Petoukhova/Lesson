Console.Clear();
Console.WriteLine("Please enter the day of the week (as a number)");

int d = Convert.ToInt32(Console.ReadLine());


while (d < 1 || d > 7) 
{
    Console.Write("Mistake... Try again!");
    d = Convert.ToInt32(Console.ReadLine());
}

if (d == 6 || d ==7)
    Console.WriteLine("Holiday!!!");
else 
    Console.WriteLine("Work day...");
