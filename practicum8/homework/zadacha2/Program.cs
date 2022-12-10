// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 21);
        }
    }
}

void PrintMatrix(int[,] matr)
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

int minSum(int[,] matr)
{
    int[] summury = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        summury[i] = sum;
    }
    Console.Write($"Суммы строк массива: ");
    for (int i = 0; i < summury.Length; i++)
    {
        Console.Write($"{summury[i]}; ");
    }
    Console.WriteLine();
    int minrow = 0;
    for (int i = 1; i < summury.Length; i++)
    {

        if (summury[i] <= summury[minrow]) minrow = i; // если строк с наим суммой несколько сделать минроу массивом/строкой в который записываются строки
    }
    return minrow + 1;
}

Console.Write("Введите количество строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов m = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой: {minSum(matrix)}");