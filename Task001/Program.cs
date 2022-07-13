/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
int SecNum(int a)
{
    int secondNum = a / 10 % 10;
    return secondNum;
}


int num = new Random().Next(100, 1000);
Console.WriteLine($"{num} -> {SecNum(num)}");