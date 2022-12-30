// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfElements(int m, int n) {
    if(n > m) {
        return n + SumOfElements(m, n - 1);
    }
    else {
        return n;
    }
}

Console.Clear();
Console.WriteLine("Привет! Эта программа принимает на ввод значения M и N, и находит сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine();

Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine();
Console.WriteLine($"Сумма натуральных элементов ммежду M и N: {SumOfElements(M, N)}");