//  Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine ());
    return a;
}
int n = Prompt("Введите трехзначное число: ");
if( n>99 && n<1000)
{
    int tmp = (n/100)%10;
    int tmp2 = n%10;
    Console.WriteLine($"{tmp}{tmp2}");
}
else 
{
    Console.WriteLine("Вы ввели не трехзначное число");
}

