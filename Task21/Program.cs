Console.Clear();
Console.WriteLine("Enter coordinetas of two points:");

Console.Write("A - X: ");

int aX = Convert.ToInt32(Console.ReadLine());

Console.Write("A - Y: ");

int aY = Convert.ToInt32(Console.ReadLine());

Console.Write("A - Z: ");

int aZ = Convert.ToInt32(Console.ReadLine());

Console.Write("B - X: ");

int bX = Convert.ToInt32(Console.ReadLine());

Console.Write("B - Y: ");

int bY = Convert.ToInt32(Console.ReadLine());

Console.Write("B - Z: ");

int bZ = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(aX - bX, 2) + Math.Pow(aY - bY, 2) + Math.Pow(aZ - bZ, 2)), 2));
