Console.Clear();

Console.WriteLine("Привет! Эта программа принимает на ввод трёхзначное число и показывает вторую цифру этого числа.");
Console.WriteLine(" ");

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");

if(number > 99 && number < 1000) {
    number /= 10;
    number %= 10;
    Console.Write($"Вторая цифра введённого числа: {number}");
}
else if(number > -1000 && number < -99) {
    number /= 10;
    number %= 10;
    number += number * -2;
    Console.Write($"Вторая цифра введённого числа: {number}");
}
else {
    Console.WriteLine("Введённое число не является трёхзначным");
}