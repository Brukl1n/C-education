Console.Clear();

Console.WriteLine("Привет! Эта программа принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine(" ");

int NumSums(int sum) {
    int result = 0;
    while(sum > 10) {
        result += sum % 10;
        sum /= 10;
    }
    result += sum;
    return result;
}
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Результатом будет число: {NumSums(num)}");