Console.Clear();
Console.WriteLine("Enter the positive number");

int n = Convert.ToInt32 (Console.ReadLine());

if (n < 100)

Console.WriteLine("This number doesn't have third digit");

else {
    while (n > 999)
    {n = n / 10;
 //   Console.WriteLine(n);
 }
    
    {n = n % 10;
    Console.WriteLine($"The third digit is {n}");}
    
}


