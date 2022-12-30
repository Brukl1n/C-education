// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermannFunction(int m, int n) {
    if(m == 0) {
        return n + 1;
    }
    else if(m > 0 && n == 0) {
        return AckermannFunction(m - 1, 1);
    }
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.Clear();
Console.WriteLine("Привет! Эта программа вычисления функции Аккермана с помощью рекурсии.");
Console.WriteLine();

Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine();
Console.WriteLine($"Результат: {AckermannFunction(M, N)}");