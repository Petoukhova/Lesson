Console.Clear();
Console.WriteLine("You need to enter minimum two positive numbers (except 0) otherwise the task does not make sense");

int max1 = Convert.ToInt32(Console.ReadLine());

int n = Convert.ToInt32(Console.ReadLine());

int max2 = 0;

if (n < max1)
    max2 = n;
else {
    max2 = max1;
    max1 = n;
}

while (n !=0)
{ n = Convert.ToInt32(Console.ReadLine());
    if (n > max2 && n < max1)
    max2 = n;
    else if (n > max1)
    max2 = max1;
    max1 = n;
}

Console.WriteLine($"The second maximum is {max2}");
