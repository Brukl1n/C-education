// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void FindNaturalNumbers(int n) {
    if(n % 2 == 0) {
        Console.Write($"{n} ");
    }
    if(n > 1) {
        FindNaturalNumbers(n - 1);
    }
}

Console.Clear();
Console.WriteLine("Привет! Эта программа принимает на ввод значение N и выводит все натуральные чётные числа в промежутке от N до 1.");
Console.WriteLine();

Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);

FindNaturalNumbers(N);