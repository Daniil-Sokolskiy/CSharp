// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
int max = Math.Max(M,N);
int min = Math.Min(N,M);int sum=0;
int Sum(int L, int K)
{

    if (L <= K)
    {
        sum =+ L;
        Sum(L++, K);
    }
    return sum;
}
Console.WriteLine($"Сумма натуральных элементов в промежутке от {min} до {max}: {Sum(min, max)}");