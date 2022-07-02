// Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine ());
    return a;
}
int a = Prompt("Введите A: ");
int b = Prompt("Введите B: ");

if(a>0 && b>0){
int d = b%a;
if(d!=0)
{
    Console.WriteLine($"Остаток от деления: {d}");
}
else
{
    Console.WriteLine($"Число {b} кратно {a}");
}
}
else Console.WriteLine("Введите числа больше 0");