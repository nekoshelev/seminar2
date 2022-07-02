//  Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}
int n = Prompt("Введите число: ");
int free = 10;

if (n > 99)
{
    Console.WriteLine(n.ToString()+" = "+n.ToString()[2]);
}
else Console.WriteLine("Третьей цифры нету");
