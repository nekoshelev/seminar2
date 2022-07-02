// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine ());
    return a;
}
int a = Prompt("Введите A: ");
int a7 = a%7;
int a23 = a%23;

if(a7==0 && a23==0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else Console.WriteLine("Число не кратно 7 и 23");