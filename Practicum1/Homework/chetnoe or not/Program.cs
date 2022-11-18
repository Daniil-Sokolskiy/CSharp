int number1 = new Random().Next(-1000, 1001);
Console.Write("Число 1 = ");
Console.WriteLine( number1);

if (number1%2 == 0) Console.WriteLine("Число является четным");
else{
    Console.WriteLine("Число является нечетным");
}
