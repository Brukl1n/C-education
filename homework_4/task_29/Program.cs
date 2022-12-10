// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 2, 4, 7 -> [1, 2, 5, 7, 19, 2, 4, 7]
// 6, 1, 33, 3, 5, 1, 2, 9 -> [6, 1, 33, 3, 5, 1, 2, 9]

Console.Clear();

Console.WriteLine("Привет! Эта программа задаёт массив из 8 элементов и выводит их на экран.");
Console.WriteLine(" ");

int[] CreateArray(int size) {
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}

void PrintArray(int[] array) {
    for(int i = 0; i < array.Length - 1; i++) {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[7] + ".");
}

Console.Write("Сгенерированный массив: ");
PrintArray(CreateArray(8));