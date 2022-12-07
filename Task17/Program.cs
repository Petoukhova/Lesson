Console.Clear();
Console.Write("Please, enter the coordinate X: ");
double X = Convert.ToDouble(Console.ReadLine());

Console.Write("Please, enter the coordinate Y: ");
double Y = Convert.ToDouble(Console.ReadLine());

while (X == 0)
{
    Console.Write("Mistake!!!\nPlease, enter the coordinate X: ");
    X = Convert.ToDouble(Console.ReadLine());  
}

while (Y == 0)
{

    Console.Write("Mistake!!!\nPlease, enter the coordinate Y: ");
    Y = Convert.ToDouble(Console.ReadLine());    
}

if (X >0 && Y > 0)
    Console.WriteLine("I");
else if (X <0 && Y > 0)
    Console.WriteLine("II");
else if (X <0 && Y < 0)
    Console.WriteLine("III");
else 
    Console.WriteLine("IV");
