Console.Clear();

Console.WriteLine("Привет! Эта программа показывает все чётные числа от 1 до N (где N это введённое пользоваетлем число).");
Console.WriteLine(" ");

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");

int count = 1;
while(count <= N) {
    if(count % 2 == 0) {
        Console.WriteLine(count);
        count++;
    }
    else {
        count++;
    }
}