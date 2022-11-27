// int[] num = {1, 2, 3, 4, 5, 6, 7};

// string b = string.Join("---", num); // переводит массив в строку 1---2---3---4---5---6---7
// Console.WriteLine(b);

// foreach (int n in num)
// {
//     Console.WriteLine(n);
// }

string s = "1, 2, 3, 4, 5, 6, 7.";
string[] nums = s.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries); // строка в массив
int[] n = nums.Select(Int32.Parse).ToArray();                                              //
foreach (var num in n)
{
    Console.WriteLine(num);
}

string s1 = "1, 2, 3, 4, 5, 6, 7.";
string s2= s1.Replace(',', ';');
Console.WriteLine(s2);