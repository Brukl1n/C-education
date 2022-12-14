// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int arraySize) {
    int[] array = new int[arraySize];
    for(int i = 0; i < arraySize - 1; i++) {
        array[i] = new Random().Next(-100, 101);
        Console.Write(array[i] + ", ");
    }
    array[arraySize - 1] = new Random().Next(-100, 101);
    Console.Write(array[arraySize - 1] + " ");
    Console.WriteLine(" ");
    return array;
}

int FindingSumOfEven(int[] actualArray) {
    int result = 0;
    for(int i = 1; i < actualArray.Length; i++) {
        if(i % 2 != 0) {
            result += actualArray[i];
        }
    }
    return result;
}

void PrintSumOfEven(int evenNumbers) {
    Console.WriteLine(" ");
    Console.Write($"Сумма элементов, стоящих на нечётных позициях: {evenNumbers}");
}

Console.Clear();

Console.WriteLine("Привет! Эта программа создаёт массив заполненный слуайными числами и показывает сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine(" ");

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");

Console.Write("Числа в массиве: ");
PrintSumOfEven(FindingSumOfEven(CreateArray(size)));