Console.Clear();
// Домашние задание №2
Console.WriteLine("*******************************");
Console.WriteLine("Введите номер задния (1, 2, 3)");
string lesson = Console.ReadLine();
Console.WriteLine("*******************************");
string result = "не существует такой задачи, попробуйте 1, 2, 3.";

switch (lesson) {
    case "1":
        /* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            456 -> 5
            782 -> 8
            918 -> 1 
        */
        int numb3char = new Random().Next(100, 1000);
        Console.WriteLine("Исходное число " + numb3char);
        numb3char = (numb3char / 10) % 10;
        result = Convert.ToString(numb3char);
        break;

    case "2":
        /* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            645 -> 5
            78 -> третьей цифры нет
            32679 -> 6
        */
        Console.WriteLine("Введите число");
        int x = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        int xCopy = x;
        while (x > 0) {         // находим количесвтво символов в числе
            x = x / 10;
            count++;
        }
        if (count > 2) {        // проверяем что бы было больше двух
            int index = 1;
            while (index <= count) {
                if (index == (count - 2)) {     // находим третипю позицию
                    result = "Третье число = " + (xCopy % 10);      // отделяемя праву часть от нашей позиции
                }
                xCopy = xCopy / 10;   // отедляем лувую часть от нашей позиции
                index++;
            }
        } else {
            result = "третьей цифры нет";
        }

        break;

    case "3":
        /* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            6 -> да
            7 -> да
            1 -> нет
        */
        Console.WriteLine("Введите чифру дня недели от 1 до 7");
        int day = Convert.ToInt32(Console.ReadLine());
        if ((day < 1) || (day > 7)) {
            result = "Нет такого дня недели.";
        } else if ((day == 6) || (day == 7)) {
            result = "Да, это выходной день!";
        } else {
            result = "Нет, ...солнце еще высоко!";
        }
        break;
}

Console.WriteLine($"Результат выполнения задади номер {lesson}: {result}");
Console.WriteLine("*******************************");