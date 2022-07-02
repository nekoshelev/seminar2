// Напишите программу, которая будет принимать на вход пять чисел и выводить сумму и среднее арифметическое этих чисел.
//2, 5, 6, 8, 1 -> сумма 22, среднее 4,4 

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine ());
    return a;
}
int a = Prompt("Введите A: ");
int b = Prompt("Введите B: ");
int c = Prompt("Введите C: ");
int d = Prompt("Введите D: ");
int e = Prompt("Введите E: ");

int sum = a+b+c+d+e;
double arif = (a+b+c+d+e)/5.0;
Console.WriteLine(sum);
Console.WriteLine(arif);
