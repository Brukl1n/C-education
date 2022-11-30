Console.Clear();

Console.WriteLine("Привет! Эта программа сравнивает три введённых числа и определяет какое из них большее.");
Console.WriteLine(" ");

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");

Console.Write("Введите третье число: ");
int numberС = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");

int max;

if(numberA > numberB && numberA > numberС) {
    max = numberA;
}
else if(numberB > numberС) {
    max = numberB;
}
else {
    max = numberС;
}

Console.WriteLine("Максимальное из трёх введённых чисел: " + max);