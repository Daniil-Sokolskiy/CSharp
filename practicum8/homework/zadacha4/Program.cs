// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] a=new int[90];
for(int i=0;i<90;i++)
{
a[i] = i+10;
}
for (int i = a.Length - 1; i >= 1; i--)
{
   int j = new Random().Next(i+1);
   var temp = a[j];
   a[j] = a[i];
   a[i] = temp;
}

Console.Write("Введите количество строк для матрицы m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для матрицы n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк для матрицы k = ");
int k = Convert.ToInt32(Console.ReadLine());
int[,,] cube = new int[m, n, k];
void FillMatrix(int[,,] matr)
{
    int l=0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = a[l];
                l++;
            }
        }
    }
}
void PrintMatrix(int[,,] matr)
{
    for (int k = 0; k < matr.GetLength(2); k++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
FillMatrix(cube);
PrintMatrix(cube);