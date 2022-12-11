// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] spiral = new int[4, 4];
void FillSpiral(int[,] matrix)
{
    int s = 1;
    int i = 0;
    int j = 0;
    for (j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = s;
        s++;
    }
    for (i = 1; i < matrix.GetLength(0); i++)
    {
        matrix[i, j = matrix.GetLength(0) - 1] = s;
        s++;
    }
    for (j = matrix.GetLength(0) - 2; j >= 0; j--)
    {
        matrix[i = matrix.GetLength(0) - 1, j] = s;
        s++;
    }
    for (i = matrix.GetLength(0) - 2; i > 0; i--)
    {
        matrix[i, j = 0] = s;
        s++;
    }
    for (j = 0+1; j < matrix.GetLength(1)-1; j++)
    {
        matrix[i+1, j] = s;
        s++;
    }
    for (i = 2; i < matrix.GetLength(0)-1; i++)
    {
        matrix[i, j = matrix.GetLength(0) - 2] = s;
        s++;
    }
    for (j = matrix.GetLength(0) - 3; j > 0; j--)
    {
        matrix[i = matrix.GetLength(0) - 2, j] = s;
        s++;
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
FillSpiral(spiral);
PrintMatrix(spiral);