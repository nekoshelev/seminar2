//  Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да 
//7 -> да 
//1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int daynumber = int.Parse(Console.ReadLine());
if (daynumber > 0 && daynumber < 8)
{
    Console.WriteLine("Является ли он выходным днем?");
    if (daynumber == 1) Console.WriteLine("Нет");
    if (daynumber == 2) Console.WriteLine("Нет");
    if (daynumber == 3) Console.WriteLine("Нет");
    if (daynumber == 4) Console.WriteLine("Нет");
    if (daynumber == 5) Console.WriteLine("Нет");
    if (daynumber == 6) Console.WriteLine("Да");
    if (daynumber == 7) Console.WriteLine("Да");
}
else{
    Console.WriteLine("Неверный номер дня недели");
}

