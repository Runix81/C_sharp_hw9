// // Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// // Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 9
// // m = 3, n = 2 -> A(m,n) = 29


// Метод ввода значений m и n

(int, int) InputNum(string msg, string message)
{
    System.Console.Write($"{msg} -> ");
    int numM = Convert.ToInt32(Console.ReadLine());
    //System.Console.WriteLine();
    System.Console.Write($"{message} -> ");
    int numN = Convert.ToInt32(Console.ReadLine());
    return (numM, numN);
}

//Метод расчета функции Аккермана 

int ack(int m, int n)
{
    while (m != 0)
    {
        if (n == 0)
        {
            n = 1;
        }
        else
        {
            n = ack(m, n - 1);
        }
        m = m - 1;
    }
    return n + 1;
}

(int m, int n) = InputNum("Введите число m","Введите число n");
System.Console.WriteLine($"{ack(m, n)}");
