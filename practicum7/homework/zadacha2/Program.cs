// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 21);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }

}

Console.Write("Введите количество строк m = ");
int m = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов n = ");
int n = Int32.Parse(Console.ReadLine());
int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);

Console.Write("Введите номер строки элемента массива = ");
int i = Int32.Parse(Console.ReadLine()) - 1;
if (i + 1 > matrix.GetLength(0))
{
    Console.WriteLine("Такой строки не существует");
}
else
{
    Console.Write("Введите номер столбца элемента массива = ");
    int j = Int32.Parse(Console.ReadLine()) - 1;
    if (j + 1 > matrix.GetLength(1))
    {
        Console.WriteLine("Такого столбца не существует");
    }
    else
        Console.WriteLine($"Элемент с индексом [{i},{j}] = {matrix[i, j]}");
}