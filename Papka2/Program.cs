/*Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 56
M = 4; N = 8. -> 18
*/
Console.Clear();
Console.WriteLine("Задайте первое число: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Задайте второе число: ");
int n = int.Parse(Console.ReadLine()!);

int SumNumbers(int m, int n)
{
    if (m <= n)
    {
        if (m % 2 == 0)
        {
            return m + SumNumbers(m + 2, n);
        }
        else
        {
            m = m + 1;
            return m + SumNumbers(m + 2, n);
        }
    }
    else return 0;
}

Console.WriteLine(SumNumbers(m, n));

int SumRec(int m, int n)
{
    int sum = 0;

    for (int i = m; i <= n; i++)
        if (i % 2 == 0) sum = sum + i;
    return sum;
}
Console.WriteLine(SumRec(m, n));
