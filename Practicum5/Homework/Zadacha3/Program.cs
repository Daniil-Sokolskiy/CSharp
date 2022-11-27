// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(double[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
}

void PrintArray(double[] array)
{
    string str = string.Join("| |", array);
    Console.WriteLine(str);
}

double DifMaxMin(double[] array)
{
    int length = array.Length;
    double max = array[0];
    double min = array[1];
    for (int i = 0; i < length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    double dif = max - min;
    return dif;
}

Console.Write("Введите величину массива: ");
int M = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[M];
FillArray(arr);
Console.WriteLine("-----Массив из чисел-----");
PrintArray(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {Math.Round(DifMaxMin(arr), 2)}");