/* Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n. 
m = 3, n = 2 -> A(m,n) = 29
 */

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int PrintAkkerman(int m, int n) //Функция Аккермана.
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return PrintAkkerman(m - 1, 1);
    if (m > 0 && n > 0) return PrintAkkerman(m - 1, PrintAkkerman(m, n - 1));
    return PrintAkkerman(m, n);
}

int m = Prompt("Введите натуральное число M ->");
int n = Prompt("Введите натуральное число N ->");
System.Console.WriteLine(PrintAkkerman(m, n));
