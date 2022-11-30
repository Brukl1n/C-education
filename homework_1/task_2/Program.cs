Console.Clear();

Console.WriteLine("Привет! Эта программа сравнивает два введённых числа и определяет какое из них большее, а какое меньшее.");
Console.WriteLine(" ");

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");

int max;
int min;

if(numberA > numberB) {
    max = numberA;
    min = numberB;
}
else {
    max = numberB;
    min = numberA;
}

Console.WriteLine("Максимальное из двух введённых чисел: " + max);
Console.WriteLine(" ");
Console.WriteLine("Минимально из двух введённых чисел: " + min);