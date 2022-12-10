// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void Sort(int[,] matrixxx)
{
    for (int i = 0; i < matrixxx.GetLength(0); i++)
    {

        for (int j = 0; j < matrixxx.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int q = j + 1; q < matrixxx.GetLength(1); q++)
            {
                if (matrixxx[i, q] > matrixxx[i, maxPosition]) maxPosition = q;
            }
            int temp = matrixxx[i, j];
            matrixxx[i, j] = matrixxx[i, maxPosition];
            matrixxx[i, maxPosition] = temp;
        }
    }
}

Console.Write("Введите количество строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Sort(matrix);
Console.WriteLine("Отсортированный двумерный массив: ");
PrintMatrix(matrix);