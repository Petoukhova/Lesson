Console.Clear();

Console.Write("Введите X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите X3: ");
double x3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());

double s = Math.Abs(((x1-x3)*(y2-y3)-(x2-x3)*(y1-y3)))/2;

Console.Write($"Площадь треугольника: {s}");