// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(0, 100);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
}

int[] a = new int[3];
FillArray(a);
Console.Write($"Координаты точки а (");
PrintArray(a);
Console.WriteLine(")");

int[] b = new int[3];
FillArray(b);
Console.Write($"Координаты точки b (");
PrintArray(b);
Console.WriteLine(")");

double x = Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2) + Math.Pow(a[2] - b[2], 2);

double r = Math.Sqrt(x);
Console.WriteLine(r);