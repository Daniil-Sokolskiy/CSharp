Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "настюша")
{
    Console.WriteLine("Я тебя люблю");
}
else
{
Console.Write("Привет, ");
Console.WriteLine(username);
}