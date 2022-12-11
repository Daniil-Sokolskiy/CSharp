// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] Multiplication(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] matrixMulti = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrixMulti[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrixMulti;
}

Console.Write("Введите количество строк для матрицы А m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для матрицы А n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[m, n];
FillMatrix(matrixA);
PrintMatrix(matrixA);
Console.WriteLine();
Console.Write("Введите количество строк для матрицы В k = ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для матрицы В l = ");
int l = Convert.ToInt32(Console.ReadLine());
int[,] matrixB = new int[k, l];
FillMatrix(matrixB);
PrintMatrix(matrixB);
Console.WriteLine();
int[,] multiplication = Multiplication(matrixA, matrixB);
Console.WriteLine("Матрица, получившаяся после перемножения: ");
PrintMatrix(multiplication);