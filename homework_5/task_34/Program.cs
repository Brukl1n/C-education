// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int arraySize) {
    int[] array = new int[arraySize];
    for(int i = 0; i < arraySize - 1; i++) {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + ", ");
    }
    array[arraySize - 1] = new Random().Next(100, 1000);
    Console.Write(array[arraySize - 1] + " ");
    Console.WriteLine(" ");
    return array;
}

int CountingEvenNumbers(int[] actualArray) {
    int result = 0;
    for(int i = 0; i < actualArray.Length; i++) {
        if(actualArray[i] % 2 == 0) {
            result += 1;
        }
    }
    return result;
}

void PrintCountEvenNumbers(int evenNumbers) {
    Console.WriteLine(" ");
    Console.Write($"Количество чётных числе в массиве: {evenNumbers}");
}

Console.Clear();

Console.WriteLine("Привет! Эта программа создаёт массив заполненный трёхзнаными числами и показывает количество чётных чисел в нём.");
Console.WriteLine(" ");

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");

Console.Write("Числа в массиве: ");
PrintCountEvenNumbers(CountingEvenNumbers(CreateArray(size)));