// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void PrintCord(int x, int y) {
    if (x > 0 && y > 0) {
        Console.WriteLine("I четверть");
    } else if (x < 0 && y > 0) {
        Console.WriteLine("II четверть");
    } else if (x < 0 && y < 0) {
        Console.WriteLine("III четверть");
    } else if (x > 0 && y < 0) {
        Console.WriteLine("VI четверть");
    } else {
        Console.WriteLine("Не входит ни в какую четверть");
    }
}

Console.Clear();
Console.WriteLine("Введите координату х");
int CordX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y");
int CordY = Convert.ToInt32(Console.ReadLine());

(PrintCord(CordX, CordY));