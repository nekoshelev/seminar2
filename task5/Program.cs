// Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
//7812 -> 8 
//1213-> 3 
//845 -> 8

int rnd (int min, int max)
{
Random rnd = new Random();
return rnd.Next(min, max);
}

int a = rnd (10, 9999);
Console.WriteLine(a);

int max = 0;

while (a>0)
{
    int tmp = a%10;
    if(tmp > max) max = tmp;
    a = a/10;
}

  Console.WriteLine(max); 
