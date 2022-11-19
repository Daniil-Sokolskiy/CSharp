int a = new Random().Next(1, 101);
int b = new Random().Next(1, 101);
int c = new Random().Next(1, 101);
int d = new Random().Next(1, 101);
int e = new Random().Next(1, 101);
int f = new Random().Next(1, 101);
int g = new Random().Next(1, 101);
int h = new Random().Next(1, 101);
int i = new Random().Next(1, 101);
Console.WriteLine($"Даны числа = {a}, {b}, {c}, {d}, {e}, {f}, {g}, {h}, {i}.");

//int max = a;
//if (b > max) max = b;
//if (c > max) max = c;
//if (d > max) max = d;
//if (e > max) max = e;
//if (f > max) max = f;
//if (g > max) max = g;
//if (h > max) max = h;
//if (i > max) max = i;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

/* int Max1 = Max(a, b, c);
Console.WriteLine($"Максимальное значение 1 = {Max1}");

int Max2 = Max(d, e, f);
Console.WriteLine($"Максимальное значение 2 = {Max2}");

int Max3 = Max(g, h, i);
Console.WriteLine($"Максимальное значение 3 = {Max3}");

int Maximum = Max(Max1, Max2, Max3); */

int Maximum = Max(Max(d, e, f), Max(a, b, c), Max(g, h, i));
Console.WriteLine($"Максимальное значение = {Maximum}");