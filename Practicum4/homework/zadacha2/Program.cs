// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int NumericLength(int personalNumber)
{
    int i = 0;
    while (personalNumber > 0)
    {
        personalNumber /= 10;
        i++;
    }
    return i;
}

int Sum(int number)
{
    int length = NumericLength(number);
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int num = Convert.ToInt32(Console.ReadLine());

int result = Sum(num);

Console.WriteLine(result);