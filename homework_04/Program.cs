Console.Clear();
Console.WriteLine("*********************************");
Console.WriteLine("Введите номер задачи");
string lesson = Console.ReadLine();
string result = "задачи не существует, попробуйте номера 1, 2, 3";

switch(lesson)
{
    case "1":
        /* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
            3, 5 -> 243 (3⁵)
            2, 4 -> 16
        */
        Console.WriteLine("Введите число А которое");
        int numbA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число B которое");
        int numbB = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        int degree = numbA;
        
        for (int i=1; i < numbB; i++)
        {
            degree = degree * numbA;
        }
        result = $"число '{numbA}' в степени '{numbB}' = {degree}";

        break;

    case "2":
        /* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            452 -> 11
            82 -> 10
            9012 -> 12
        */
        Console.WriteLine("Введите число");
        int numbTwo = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        result = $"Сумма цифр числа '{numbTwo}' = ";
        numbTwo = Math.Abs(numbTwo);
        while (numbTwo > 0)
        {
            sum = sum + numbTwo % 10;
            numbTwo = numbTwo / 10;
        }
        result += $"{sum}";

        break;

    case "3":
        /* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
            1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
            6, 1, 33 -> [6, 1, 33]
        */
        result = "[";
        int[] array = new int[8];
        for(int i=0; i < array.Length; i++)
        {
            array[i] = new Random().Next(100);
            result += $"{array[i]}";
            if (!(i == array.Length - 1)) {
                result += $", ";
            }
        }
        result += $"]";

        break;
}

Console.WriteLine("*********************************");
Console.WriteLine($"Результат выполнения задачи номер '{lesson}': {result}");
Console.WriteLine("");