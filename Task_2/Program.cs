// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт
//  сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

// Метод ввода значений M и N

(int, int) InputNum(string msg, string message)
{
    System.Console.Write($"{msg} -> ");
    int numM = Convert.ToInt32(Console.ReadLine());
    //System.Console.WriteLine();
    System.Console.Write($"{message} -> ");
    int numN = Convert.ToInt32(Console.ReadLine());
    return (numM, numN);
}

// Метод подсчета суммы элементов между M и N

int ElementSum(int numM, int numN)
{
    if (numM == numN) return numM;

    return numM + ElementSum(numM + 1, numN);
}

(int M, int N) = InputNum("Введите число M", "Введите число N");
int res = ElementSum(M, N);
System.Console.WriteLine($"{res}");

