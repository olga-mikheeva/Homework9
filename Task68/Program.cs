/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}


int Ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    } 
    else if (n == 0 && m > 0)
    {
        return Ack(m - 1, 1);
    } 
    else
    {
        return Ack(m - 1, Ack(m, n - 1));
    }
}

int number1 = InputNum("Введите число m: ");
int number2 = InputNum("Введите число n: ");

int num = Ack(number1, number2);
Console.WriteLine(num);
