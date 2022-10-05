/*Задача 22:**
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/
using static System.Console;
Clear();
Write("enter the number: ");
int number=Convert.ToInt32(ReadLine());
int count=1;
while (count<=number)
{
    Write($"{Math.Pow(count,2)} ");
    count++;
}