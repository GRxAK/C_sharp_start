// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();

string quarter = Console.ReadLine();

switch (quarter) {

    case "1":
        Console.WriteLine("x от 0 и больше, y от 0 и больше");
    break;
    
    case "2":
        Console.WriteLine("x от 0 и меньше, y от 0 и больше");
    break;
    
    case "3":
        Console.WriteLine("x от 0 и меншье, y от 0 и меншье");
    break;
    
    case "4":
        Console.WriteLine("x от 0 и больше, y от 0 и меншье");
    break;
}
