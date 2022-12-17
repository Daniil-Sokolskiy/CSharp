// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
int max = Math.Max(M, N);
int min = Math.Min(N, M);
void Sum(int L, int K, int sum)
{
    if (L > K) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (L++);
    Sum(L, K, sum);
}

Sum(min, max, 0);

