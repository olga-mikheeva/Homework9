/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int SumNumsBetween(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    return m + SumNumsBetween(m + 1, n);
}


int m = InputNum("Введите число M: ");
int n = InputNum("Введите число N: ");

int sum = SumNumsBetween(m, n);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {sum}");

// M = 4; N = 8. -> 30

// вошли в SumNumsBetween(4, 8);
// 4 + [5, 8]
//     вошли в SumNumsBetween(5, 8);
// 4 + 5 + [6, 8]
//         вошли в SumNumsBetween(6, 8);
// 4 + 5 + 6 + [7, 8]
//             вошли в SumNumsBetween(7, 8);
// 4 + 5 + 6 + 7 + [8, 8]
//                 вошли в SumNumsBetween(8, 8);
// 4 + 5 + 6 + 7 + 8 + [9, 8]
//                      вошли в SumNumsBetween(9, 8);
// 4 + 5 + 6 + 7 + 8 + 0
//                      вышли из SumNumsBetween(9, 8);
//                 вышли из SumNumsBetween(8, 8);
//             вышли из SumNumsBetween(7, 8);
//         вышли из SumNumsBetween(6, 8);
//     вышли из SumNumsBetween(5, 8);
// вышли из SumNumsBetween(4, 8);