int AskNum(int a)
{
    int res;
    if (a > 0)
    {
        Console.Write($"Enter {a} num: ");
        res = int.Parse(Console.ReadLine());
        return res;
    }
    else
    {
        Console.Write($"Enter num: ");
        res = int.Parse(Console.ReadLine());
        return res;
    }

}

int CountNum(int b)
{
    int count = 0;

    while (b > 0)
    {
        count++;
        b = b / 10;
    }
    return count;
}

int Deg(int c)
{
    int res = 1;
    while (c > 3)
    {
        res *= 10;
        c--;
    }
    return res;
}

int num = AskNum(0);
int count = CountNum(num);
int deg = Deg(count);

if (count > 2)
{
    int resalt = (num / deg) % 10;
    Console.WriteLine($"{num} -> {resalt}");
}
else
{
    Console.WriteLine($"{num} -> Тo third digit");
}


