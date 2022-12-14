// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateArray(int arraySize) {
    int[] array = new int[arraySize];
    for(int i = 0; i < arraySize; i++) {
        array[i] = new Random().Next(0, 100);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
    return array;
}

int[] FindMinMaxElements(int[] actualArray) {
    int[] minMaxArray = new int[2];

    int min = actualArray[0];
    for(int i = 1; i < actualArray.Length; i++) {
        if(min > actualArray[i]) {
            min = actualArray[i];
        }
    }
    minMaxArray[0] = min;
    Console.WriteLine(" ");
    Console.WriteLine($"Минимальный элемент: {minMaxArray[0]}");

    int max = actualArray[0];
    for(int i = 1; i < actualArray.Length; i++) {
        if(max < actualArray[i]) {
            max = actualArray[i];
        }
    }
    minMaxArray[1] = max;
    Console.WriteLine(" ");
    Console.WriteLine($"Максимальный элемент: {minMaxArray[1]}");

    return minMaxArray;
}

void MinMaxDifference(int[] differenceArray) {
    int result = differenceArray[1] - differenceArray[0];
    Console.WriteLine(" ");
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {result}");
}

Console.Clear();

Console.WriteLine("Привет! Эта программа создаёт массив вещественных чисел и находит разницу между максимальным и минимальным элементом.");
Console.WriteLine(" ");

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");

MinMaxDifference(FindMinMaxElements(CreateArray(size)));