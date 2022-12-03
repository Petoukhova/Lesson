Console.Clear();
Console.Write("Please, enter the first number: ");

int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, enter the second number: ");

int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 == n2) {

Console.WriteLine("The both number are equal");

}

else if (n1 > n2) {

Console.WriteLine($"The biggest number is {n1}");
Console.WriteLine($"The smallest number is {n2}");
}
else {
Console.WriteLine($"The biggest number is {n2}");
Console.WriteLine($"The smallest number is {n1}");
}