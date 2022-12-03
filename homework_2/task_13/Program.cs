Console.Clear();

Console.WriteLine("Привет! Эта программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine(" ");

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");

if(number > 99) {
    while(number > 999) {
        number /= 10;
    }
    number %= 10;
    Console.Write($"Третья цифра заданного числа: {number}");
}
else if(number < -99) {
    while(number < -999) {
        number /= 10;
    }
    number %= 10;
    number += number * -2;
    Console.Write($"Третья цифра заданного числа: {number}");
}
else {
    Console.Write("В введённом числе нет третьей цифры!");
}