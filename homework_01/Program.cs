// Домашнии задания к первому семинару
Console.Clear();
Console.WriteLine("Ведите номер задачи 1, 2, 3, 4");
string lesson = Console.ReadLine();
Console.WriteLine("**********************");
string result = "Такой задачи нет! Диапазон номеров задачь от 1 до 4 включительно.";

switch (lesson)
{
    case "1":
        // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

        Console.WriteLine("Введите первой чилсо");
        int numb1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите воторое чилсо");
        int numb2 = Convert.ToInt32(Console.ReadLine());
        result = "Числа: " + numb1 + " и " + numb2 + ", тогда ";
        if (numb1 > numb2) {
            result += numb1 + " > " + numb2;
        } else {
            result += numb2 + " > " + numb1;
        }
        

        break;
    case "2":
        // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

        Console.WriteLine("Введите первой чилсо");
        int numbA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите воторое чилсо");
        int numbB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите третие чилсо");
        int numbC = Convert.ToInt32(Console.ReadLine());
        result = "Максимальное число = ";
        if ((numbA >= numbB) && (numbA >= numbC)) {
            result += + numbA;
        } else if ((numbB >= numbA) && (numbB >= numbC)) {
            result += + numbB;
        } else {
            result += + numbC;
        }

        break;
    case "3":
        // Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

        Console.WriteLine("Введите чилсо");
        double number = Convert.ToDouble(Console.ReadLine());
        if ((number % 2) == 0) {
            result = number + " четное число";
        } else {
            result = number + " нечетное число";
        }

        break;
    case "4":
        // Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

        Console.WriteLine("Введите чилсо");
        double numbN = Convert.ToDouble(Console.ReadLine());
        result = "Все четные числа: ";
        for (int i=2; i <= numbN; i++) {
            if ((i % 2) == 0) {
                result += i + " ";
            }
        }

        break;
}

Console.WriteLine("**********************");
Console.WriteLine("Резултат задачи #" + lesson);
Console.WriteLine(result);
Console.WriteLine("**********************");