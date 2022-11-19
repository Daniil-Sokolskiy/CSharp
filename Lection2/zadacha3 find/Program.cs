int[] array = { 23, 43, 67, 75, 34, 85, 66, 1, 5, 85, 92 };
int n = array.Length;
int find = 85;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
