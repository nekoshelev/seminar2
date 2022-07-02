// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8 
//12-> 2 
//85 -> 8

int rnd (int min, int max)
{
Random rnd = new Random();
return rnd.Next(min, max);
}

int a = rnd (10, 99);
Console.WriteLine(a);

int first = a%10;
int second = a/10;

if(first>second)
{
    Console.WriteLine(first);
}
else
{
  Console.WriteLine(second); 
}