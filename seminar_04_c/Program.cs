Console.Clear();
/*
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/
int Multiply(int n)
{
    int x = 1;
    for (int i=1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}
Console.WriteLine("Введите чило N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Multiply(n));