// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write($"Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write($"Таблица кубов чисел до числа N");
for (int i = 0; i<=N; i++)
{
double x = Math.Pow(i, 3);
Console.WriteLine($"| {x} |");
Console.WriteLine("------");
}