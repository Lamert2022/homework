/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите число 1: ");
var str = Console.ReadLine();
int num0 = Convert.ToInt32(str);
Console.Write("Введите число 2: ");
str = Console.ReadLine();
int num1 = Convert.ToInt32(str);

if (num0 > num1)
{
   Console.WriteLine($"{num0} больше числа {num1}"); 
}
else
{
    if (num0 < num1)
    {
     Console.WriteLine($"{num1} больше числа {num0}");
    }else
    {
        Console.WriteLine($"Числа {num1} и {num0} равны");  
    }
}
