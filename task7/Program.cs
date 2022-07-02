//  Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, 
//кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
//Введенное число 2
//13 -> нет 
//15 -> нет 
//12 -> да

int a = 3;
int[] numbers = new int[10];
// int[] numbers = new int[new Random().Next(1,10)];
// numbers.Length = new Random().Next(1,10);

int count = 0;

while (count < numbers.Length)
{
numbers[count] = new Random().Next(0, 99);
count++;
}

int i1 = 0;
while (i1 < numbers.Length)
{
Console.WriteLine(numbers[i1]);
i1++;
}

int i2 = 0;
while (i2 < numbers.Length)
{
if(numbers[i2]%a == 0)
{
break;
}
i2++;
}
Console.WriteLine("Число, на котором остановились " + numbers[i2]);
