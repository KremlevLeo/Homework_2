int AskNum(int a)
{
    int res;
    if (a > 0)
    {
        Console.Write($"Enter {a} number: ");
        res = int.Parse(Console.ReadLine());
        return res;
    }
    else
    {
        Console.Write($"Enter number: ");
        res = int.Parse(Console.ReadLine());
        return res;
    }

}

int day = AskNum(0);
if (day == 6 || day == 7)
{
    Console.WriteLine($"{day} -> Yes");
}
else
{
    Console.WriteLine($"{day} -> No");
}