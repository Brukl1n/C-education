Console.Clear();

Console.WriteLine("Привет! Эта программа определяет является ли введённое число чётным.");
Console.WriteLine(" ");

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");

int result;
result = number % 2;

if(result == 0) {
    Console.Write("Введённое число является чётным");
}
else {
    Console.Write("Введённое число не является чётным");
}