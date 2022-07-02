//  Задача 1: Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine ());
    return a;
}
int n = Prompt("Введите трехзначное число: ");
if( n>99 && n<1000)
{
    int tmp = (n/10)%10;
    Console.WriteLine(tmp);
}
else 
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
