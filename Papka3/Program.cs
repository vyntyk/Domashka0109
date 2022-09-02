/* Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.(необязательная)
m = 2, n = 3 -> A(m,n) = 29
*/

Console.Clear();

Console.WriteLine("Задайте первое число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return FunctionAkkerman(m - 1, 1);
    else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}
		
Console.WriteLine($"Функция Аккермана = "+ FunctionAkkerman(m, n));