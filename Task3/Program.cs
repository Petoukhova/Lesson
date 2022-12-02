Console.Clear();
Console.WriteLine("Please enter the day of the week (as a number)");

int d = Convert.ToInt32(Console.ReadLine());


while (d < 1 || d > 7) 
{
    Console.Write("Mistake... Try again!");
    d = Convert.ToInt32(Console.ReadLine());
}

if (d == 1)
    Console.WriteLine("Monday");
else if (d == 2)
    Console.WriteLine("Tuesday");
else if (d == 3)
    Console.WriteLine("Wednesday"); 
else if (d == 4)
    Console.WriteLine("Thursday"); 
else if (d == 5)
    Console.WriteLine("Friday"); 
else if (d == 6)
    Console.WriteLine("Saturday!!!"); 
else 
    Console.WriteLine("Sunday!!!"); 
