Console.Clear();

Console.WriteLine("Привет! Эта программа принимает на вход число N и выдаёт таблицу кубов чисел от 1 до N.");
Console.WriteLine(" ");

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int count = 1;

while(count < N) {
    Console.Write(Math.Pow(count, 3) + ", ");
    count++;
}

Console.Write(Math.Pow(count, 3));