/* Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
 */

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintNaturalSumm(int n, int m, int sum) //Сумма чисел через рекурсию.
{

    if (m > n)
    {
        System.Console.WriteLine(" Сумма чисел равна = " + sum);
        return;
    }
    System.Console.Write($" {m}");
    sum = sum + m++;
    PrintNaturalSumm(n, m, sum);
}

int m = Prompt("Введите натуральное число M ->");
int n = Prompt("Введите натуральное число N ->");
PrintNaturalSumm(n, m, 0);
