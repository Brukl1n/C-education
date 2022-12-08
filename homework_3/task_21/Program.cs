Console.Clear();

Console.WriteLine("Привет! Эта программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine(" ");

Console.Write("Введите координату X первой точки: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y первой точки: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z первой точки: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату X второй точки: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y второй точки: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z второй точки: ");
int z2 = int.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"расстояние мужду двух точек равно {distance}");