int Exponentiation(int numA, int numB) {
    int result = 1;
    for(int i = 1; i <= numB; i++) {
        result *= numA;
    }
    return result;
}

Console.Clear();
Console.WriteLine("Привет! Эта программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine(" ");

Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

Console.Write($"Результатом будет число: {Exponentiation(A, B)}");