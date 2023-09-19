/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void PrintNumbers(int n)
{
    if (n > 1)
    {
        Console.Write(n + ", ");
        PrintNumbers(n - 1);
    }
    else
    {
       Console.Write(1); 
    }
}

int number = InputNum("Введите число: ");
PrintNumbers(number);

// Точка входа
//      вошли в InputNum
//      вышли из InputNum
//      вошли в PrintNumbers(5);
//          вошли в PrintNumbers(4);
//              вошли в PrintNumbers(3);
//                  вошли в PrintNumbers(2);
//                      вошли в PrintNumbers(1);
//                          вошли в PrintNumbers(0);
//                          вышли из PrintNumbers(0);
//                      вышли из PrintNumbers(1);
//                  вышли из PrintNumbers(2);
//               вышли из PrintNumbers(3);
//           вышли из PrintNumbers(4);
//       вышли из PrintNumbers(5);
