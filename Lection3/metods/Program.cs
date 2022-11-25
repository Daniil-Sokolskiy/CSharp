//type 1 Ничего не принимают, ничего не возвращают

void Method1()
{
    Console.WriteLine("Author...");
}
// Method1();

//Type2 Ничего не возвращают, но принимают аргументы

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg: "Text of message...");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Text of message...", 4);
// Method21(count:4, msg:"Text of message...");

// Type 3 Возвращают

int Method3()
{
    return DateTime.Now.Year;
}

//int year = Method3();
//Console.WriteLine(year);

//Type 4 

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "Zhopa");
Console.WriteLine(res);