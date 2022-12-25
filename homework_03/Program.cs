// домашние задание №3
Console.Clear();
Console.WriteLine("*********************************");
Console.WriteLine("Введите номер задачи");
string lesson = Console.ReadLine();
string result = "задачи не существует, попробуйте номера 1, 2, 3";

switch (lesson)
{
    case "1":
        /* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
            14212 -> нет
            12821 -> да
            23432 -> да
        */
        Console.WriteLine("Введите 5-и значное число");
        int numb = Convert.ToInt32(Console.ReadLine());
        string numb2 = "";
        numb = Math.Abs(numb);
        if (numb > 9999 && numb < 100000) {
            numb2 = $"{numb % 10}{(numb % 100)/10}";
            numb = numb / 1000;
            if (Convert.ToString(numb) == numb2) {
                result = $"ДА";
            } else {
                result = $"НЕТ";
            }
        } else {
            result = "чило не подходит под заданные параметры";
        }

        break;

    case "2":
        /* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            A (3,6,8); B (2,1,-7), -> 15.84
            A (7,-5, 0); B (1,-1,9) -> 11.53
        */
        // int x1 = 3;
        // int y1 = 6;
        // int z1 = 8;
        // int x2 = 2;
        // int y2 = 1;
        // int z2 = -7;
        int x1 = new Random().Next(-10, 11);
        int y1 = new Random().Next(-10, 11);
        int z1 = new Random().Next(-10, 11);
        int x2 = new Random().Next(-10, 11);
        int y2 = new Random().Next(-10, 11);
        int z2 = new Random().Next(-10, 11);
        Console.WriteLine($"A({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2})");
        double distance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));
        result = $"растояние = {Math.Round(distance, 2)}";
        break;

    case "3":
        /* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            3 -> 1, 8, 27
            5 -> 1, 8, 27, 64, 125
        */
        result = "";
        Console.WriteLine("Введите число ");
        int sqrt = Convert.ToInt32(Console.ReadLine());
        for (int i=1; i <= sqrt; i++) {
            result += ( i * i * i + " ");
        }
        break;
}

Console.WriteLine("*********************************");
Console.WriteLine($"Результат выполнения задачи номер {lesson}: {result}");