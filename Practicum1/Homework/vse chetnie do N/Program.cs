int N = new Random().Next(1, 151);
Console.Write("Число N = ");
Console.WriteLine(N);
Console.Write("В диапазоне от 1 до ");
Console.Write(N);
Console.Write(" четными являются следующие числа: ");
int count = 1;
while (count < N)
{
    if (count % 2 == 0)
    {
        Console.Write(count);
        Console.Write(", ");
    }
    count++;
}
