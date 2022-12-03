Console.Clear();

Console.WriteLine("Привет! Эта программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.WriteLine(" ");

Console.Write("Введите число, обозначающее день недели: ");
int day = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");

if(day == 6 || day == 7) {
    Console.Write("Введённый день недели является выходным!");
}
else if(day >= 1 && day <= 5) {
    Console.Write("Введённый день недели является будним!");
}
else {
    Console.Write("Введённое число не является днём недели!");
}