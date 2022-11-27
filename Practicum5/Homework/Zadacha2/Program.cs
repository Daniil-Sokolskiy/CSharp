// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
}

void PrintArray(int[] array)
{
    string str = string.Join("| |", array);
    Console.WriteLine(str);
}

int SumOfOdd(int[] array)
{
    int sum=0;
    int length = array.Length;
    for (int index = 0; index < length; index++)
    {
        if(index%2!=0) sum+=array[index];
    }
    return sum;
}

Console.Write("Введите величину массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[M];
FillArray(arr);
Console.WriteLine("-----Массив из чисел-----");
PrintArray(arr);
Console.WriteLine($"Сумма элементов массива стоящих на нечётных позициях: {SumOfOdd(arr)}");