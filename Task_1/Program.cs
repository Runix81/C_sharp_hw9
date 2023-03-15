// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

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


// Метод вывода результата в консоль


void PrintResult(int M, int N)
{
    if (M <= N)
    {
        if (M % 2 == 0)
        {
            System.Console.Write($"{M}, ");
            M += 2;
            PrintResult(M,N);
        }
        else
        {
            M++;
            PrintResult(M,N);
        }

    }
    else 
    {
        System.Console.WriteLine();
        //System.Console.Write("_____________________");
        
    }
    return;
}

(int M, int N) = InputNum("Введите число M", "Введите число N");
PrintResult(M,N);


