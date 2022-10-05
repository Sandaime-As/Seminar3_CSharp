/*Напишите программу, которая принимает на вход координаты точки (X и Y),
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/
using static System.Console;
Clear();
Write("Введите координату Х: ");            //X>0 Y>0 -1
int num1=int.Parse(ReadLine()!);            //X>0 Y<0 -2
Write("Введите координату Y: ");            //X<0 Y<0 -3
int num2=int.Parse(ReadLine()!);            //X<0 Y>0 -4
if(num1==0 && num2==0 || num1>=0 && num2>=0 || num1<=0 && num2<=0)
{
    WriteLine("error!");
    return;
}
if(num1>=0 && num2>=0)
{
    WriteLine("Номер четверти: 1");
}
if(num1>0 && num2<0)
{
    WriteLine("Номер четверти: 2");
}
if(num1<0 && num2<0)
{
    WriteLine("Номер четверти: 3");
}
if(num1<0 && num2>0)
{
    WriteLine("Номер четверти: 4");
}