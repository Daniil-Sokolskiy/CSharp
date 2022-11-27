// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    string str = string.Join("| |", array);
    Console.WriteLine(str);
}

int Evenness(int[] array)
{
    int count = 0;
    foreach (var num in array)
    {
        if (num % 2 == 0) count++;
    }
    return count;
}

Console.Write("Введите величину массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[M];
FillArray(arr);
Console.WriteLine("-----Массив из чисел-----");
PrintArray(arr);
Console.WriteLine($"Количество четных элеметов в массиве: {Evenness(arr)}");