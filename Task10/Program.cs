Console.Clear();
Console.WriteLine("Enter a three-digit number");

int n = Convert.ToInt32 (Console.ReadLine());

int n1 = n / 10;

int total = n1 % 10;

Console.WriteLine($"The second digit is - {total}");
