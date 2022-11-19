/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным. */
int day = new Random().Next(1,8);
Console.WriteLine(day);

if (day == 6 || day ==7) Console.WriteLine("Это выходной");
else Console.WriteLine("Это будний день");