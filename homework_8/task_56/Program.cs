// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateArray() {
    int[,] array = new int[4, 4];

    return array;
}

int[,] FillArray(int[,] emptyArray) {
    for(int i = 0; i < emptyArray.GetLength(0); i++) {
        for(int j = 0; j < emptyArray.GetLength(1); j++) {
            emptyArray[i, j] = new Random().Next(1, 10);
            Console.Write(emptyArray[i,j] + " "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    return emptyArray;
}

void FindRow(int[,] filledArray) {
    int[] sumsOfElements = new int[filledArray.GetLength(0)];

    for(int i = 0; i < filledArray.GetLength(0); i++) {
        int sum = 0;

        for(int j = 0; j < filledArray.GetLength(1); j++) {
            sum += filledArray[i, j];
        }

        sumsOfElements[i] = sum;
    }

    for(int i = 0; i < sumsOfElements.Length; i++) {
        Console.Write($"Сумма элементов {i + 1}-й строки: ");
        Console.WriteLine(sumsOfElements[i]);
    }
    Console.WriteLine();

    int minRow = sumsOfElements[0];
    int minIndex = 0;
    for(int i = 1; i < sumsOfElements.Length; i++) {
        if(sumsOfElements[i] < minRow) {
            minRow = sumsOfElements[i];
            minIndex = i;
        }
    }

    Console.Write($"Строка с наименьшей суммой элементов: {minIndex + 1}-я");
}

Console.Clear();
Console.WriteLine("Привет! Эта программа находит строку с наименьшей суммой элементов.");
Console.WriteLine();

FindRow(FillArray(CreateArray()));