// Задача 18 Напишите программу, которая по заданному номеру четверти,
//показывает диапазон возможных координат точек в этой четверти (x и y)
using static System.Console;
Clear();
Write("Введите номер четверти: ");
int num=int.Parse(ReadLine()!);
if(num<1||num>4)
{
    WriteLine("error!");
    return;
}
if(num==1)
{
    WriteLine("X>0 Y>0");
}
if(num==2)
{
    WriteLine("X>0 Y<0");
}
if(num==3)
{
    WriteLine("X<0 Y<0");
}
if(num==4)
{
    WriteLine("X<0 Y>0");
}

// switch(num)
// {
//     case 1:
//     {
//         WriteLine("X>0 Y>0");
//         break;
//     }
//     case 2:
//     {
//         WriteLine("X>0 Y<0");
//         break;
//     }
//     case 3:
//     {
//         WriteLine("X<0 Y<0");
//         break;
//     }
//     case 4:
//     {
//         WriteLine("X<0 Y>0");
//         break;
//     }
//     default:
//     {
//         WriteLine("Error!");
//         break;
//     }
// }   