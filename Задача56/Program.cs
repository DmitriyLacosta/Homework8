// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine();
Console.WriteLine("Программа, создает массив по данным пользователя и ищет строку с наименьшей суммой элементов массива");
Console.WriteLine();

uint rows;
uint columns;
RowsRead();
ColumnsRead();

int[,] array = CreateRandomArray(rows, columns);
Console.WriteLine("Сгенерированный массив: ");
PrintArray(array);
SumLineElements(array);

// Функция считывания количества строк из консоли
void RowsRead() 
{
    Console.WriteLine("Введите количество строк: ");
    while (!uint.TryParse(Console.ReadLine()!, out rows) || (rows == 0))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Неверный ввод");
        Console.ResetColor();
        Console.WriteLine("Введите количество строк: ");
    }
}

// Функция считывания количества столбцов из консоли
void ColumnsRead() 
{
    Console.WriteLine("Введите количество столбцов: ");
    while (!uint.TryParse(Console.ReadLine()!, out columns) || (columns == 0))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Неверный ввод");
        Console.ResetColor();
        Console.WriteLine("Введите количество столбцов: ");
    }
}

// Функция создания массива
int[,] CreateRandomArray(uint rows, uint columns) 
{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

// Функция вывода массива в консоль
void PrintArray(int[,] array) 
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,4}", array[i, j]));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Функция вывода строки и суммы строки массива с наименьшей суммой элементов в консоль
void SumLineElements(int[,] array)
{
    int index = 0;
    int sumLine = int.MaxValue;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i, j];
        }
        if (temp < sumLine)
        {
            sumLine = temp;
            index = i;
        }
    }
    Console.WriteLine($"Строка массива с наименьшей суммой элементов: " + (index + 1) + "." + " Сумма элементов строки: " + sumLine);
}