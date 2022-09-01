/*Задача 64: Задайте значения M и N. Напишите программу, которая 
выведет все натуральные числа в промежутке от M до N от большего к меньшему.
M = 1; N = 5. -> ""5, 4, 3, 2, 1""
M = 4; N = 8. -> ""8, 7, 6, 5, 4""
*/
Console.Clear();

Console.WriteLine("Задайте первое число: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Задайте второе число: ");
int m = int.Parse(Console.ReadLine());

void NumbersMN(int m, int n)
{
    if (m <= n)
    {
        Console.Write($"{n} ");
        if (m == n) return;
        NumbersMN(n - 1, m);
    }
    else if (m >= n)
    {
        Console.Write($"{m} ");
        if (m == n) return;
        NumbersMN(m - 1, n);        
    }
}
NumbersMN(n, m);