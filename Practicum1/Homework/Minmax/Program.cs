int number1 = new Random().Next(-1000, 1001);
Console.Write("Число 1 = ");
Console.WriteLine(number1);
int number2 = new Random().Next(-1000, 1001);
Console.Write("Число 2 = ");
Console.WriteLine(number2);


int max = number1;
int min = number2;
if (number2 > max)
{
    max = number2;
    min = number1;
}
else
{
    max = number1;
    min = number2;
}

Console.Write("Максимальное из чисел = ");
Console.WriteLine(max);

Console.Write("Минимальное из чисел = ");
Console.Write(min);