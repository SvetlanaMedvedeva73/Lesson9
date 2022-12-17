/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
 */

int n;
Console.Write($"Введите N: ");
int.TryParse(Console.ReadLine()!, out n);

PrintNums(1, n);

void PrintNums(int left, int right)
{
    if (left == right || left >= right)
        Console.Write($"{left} ");
    else
    {
        Console.Write($"{left} ");
        PrintNums(left + 1, right);
    }
}

