Console.Clear();
Console.Write("Please, enter the number: ");

int n = Convert.ToInt32(Console.ReadLine());

if (n <2) {

    Console.Write("You entered too little number... Try again! ");

    n = Convert.ToInt32(Console.ReadLine());
}

for (int i = 2; i <=n; i = i + 2)
{
    Console.Write($"{i} ");
}
