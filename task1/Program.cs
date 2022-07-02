// 1. Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine ());
    return a;
}
int n = Prompt("Введите трехзначное число: ");
if( n>99 && n<1000)
{
    System.Console.WriteLine(n%10);
}
else 
{
    Console.WriteLine("Вы ввели не трехзначное число");
}