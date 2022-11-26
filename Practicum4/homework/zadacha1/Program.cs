// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

void Print(double f)
{
    Console.WriteLine(f);
}

double XvstepeniY(double x, int y)
{
    double result = Math.Pow(x, y);
    return result;
}

double A = Math.Round(new Random().NextDouble() * 10, 1);
int B = new Random().Next(0, 11);

Print(A);
Print(B);

double z = Math.Round(XvstepeniY(A, B), 2);
Print(z);