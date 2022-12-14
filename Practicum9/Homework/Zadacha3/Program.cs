// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

double Ackerman(double n, double m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Ackerman(n - 1, 1);
    else
        return Ackerman(n - 1, Ackerman(n, m - 1));
}
Console.Write("Введите значение N: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение M: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Функция Аккермана для чисел {num1} и {num2} = {Ackerman(num1, num2)}");