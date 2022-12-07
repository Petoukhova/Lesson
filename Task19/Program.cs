// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Для 5-значного числа это работает (даже если первой цифрой поставить "0"), хотелось бы как-то привязаться к длине вводимого числа, 
//чтобы сделать код универсальным...


Console.Clear();
Console.WriteLine("Please, enter the 5-digits number");
int n = Convert.ToInt32(Console.ReadLine());

int [] array = new int [n];

for (int i = 4; i >=0; i=i-1) 
{
    array [i] = n%10;
    n = n / 10;

}
    int l = 0;
    if (array[l]==array[4-l] && array [l+1] == array [4-1-l])
    Console.WriteLine("Profit!!! This number is palindrome!!!");
    else 
    Console.WriteLine("Unfortunattly...");


