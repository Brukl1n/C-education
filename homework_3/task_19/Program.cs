Console.Clear();

Console.WriteLine("Привет! Эта программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine(" ");

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
int buf = 0;

if(num > 9999 && num < 100000) {
    buf = num % 10 * 10000;
    buf += num / 10 % 10 * 1000;
    buf += num / 100 % 10 * 100;
    buf += num / 1000 % 10 * 10;
    buf += num / 10000 % 10 * 1; // умножение на 1 в конце сделал просто для красоты :D
    if(num == buf) {
        Console.WriteLine("Введённое число является палиндромом.");
    }
    else {
        Console.WriteLine("Введённое число не является палиндромом.");
    }
}
else if(num < -9999 && num > -100000) {
    buf = num % 10 * 10000;
    buf += num / 10 % 10 * 1000;
    buf += num / 100 % 10 * 100;
    buf += num / 1000 % 10 * 10;
    buf += num / 10000 % 10 * 1;
    if(num == buf) {
        Console.WriteLine("Введённое число является палиндромом.");
    }
    else {
        Console.WriteLine("Введённое число не является палиндромом.");
    }
}
else {
    Console.WriteLine("Введённое число не является пятизначным.");
}