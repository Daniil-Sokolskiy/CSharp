int number1 = new Random().Next(-1000, 1001);
Console.Write("Число 1 = ");
Console.WriteLine( number1);
int number2 = new Random().Next(-1000, 1001);
Console.Write("Число 2 = ");
Console.WriteLine( number2);
int number3 = new Random().Next(-1000, 1001);
Console.Write("Число 3 = ");
Console.WriteLine( number3);

int max = number1;

if(number2>max) max = number2;
if(number3>max) max = number3;

Console.Write("Максимальное из чисел = ");
Console.Write( max);
