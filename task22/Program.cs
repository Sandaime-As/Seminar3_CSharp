/*Напишите программу,
которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21*/
using static System.Console;
Clear();
Write("Введите координату Х1: ");
int x1=Convert.ToInt32(ReadLine()!);
Write("Введите координату Y1: ");
int y1=Convert.ToInt32(ReadLine()!);
Write("Введите координату Х2: ");
int x2=Convert.ToInt32(ReadLine()!);
Write("Введите координату Y2: ");
int y2=Convert.ToInt32(ReadLine()!);
double num=Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)); //Math.Pow(...,2) - возведение в степень, например во 2 степень
WriteLine($"Расстояние между точками в 2D пространстве = {num:f3}");    //f и добавление числа "f2" позволяет округлить до определенного числа после запятой
