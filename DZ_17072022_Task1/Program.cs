/* Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
 */

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintNatural(int n, int m)
{
    if (n < m)
    {
        System.Console.WriteLine("Условие выхода сработало");
        return;
    }
    PrintNatural(n - 1, m);
    if (n % 2 == 0) System.Console.Write($" {n}");
}

int m = Prompt("Введите натуральное число M ->");
int n = Prompt("Введите натуральное число N ->");
PrintNatural(n, m);