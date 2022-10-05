// Про корабли. Девочка и 2 мальчика делают кораблики. Девочка всегда делает на 2 кораблика больше, чем мальчики
// Д - 4
// М1 - 2
// М2 - 2

using static System.Console;
Clear();
Write("Введите сделанных корабликов: ");
int Number = Convert.ToInt32(ReadLine());
double Ship = Number/6;
WriteLine($"Девочка сделала {Ship*4} корабликов");
WriteLine($"Каждый мальчик сделал по {Ship} корабликов");