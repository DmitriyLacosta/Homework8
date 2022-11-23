// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine();
Console.WriteLine("Программа, упорядочивает элементы каждой строки двумерного массива по убыванию");
Console.WriteLine();

uint rows;
uint columns;
RowsRead();
ColumnsRead();

int[,] array = CreateRandomArray(rows, columns);
Console.WriteLine();
Console.WriteLine("Сгенерированный массив: ");
PrintArray(array);
Console.WriteLine("Отсортированный массив: ");
OrderArrayLines(array);
PrintArray(array);

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
    Console.WriteLine("Введите количество столбцов ");
    while (!uint.TryParse(Console.ReadLine()!, out columns) || (columns == 0))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Неверный ввод");
        Console.ResetColor();
        Console.WriteLine("Введите количество столбцов ");
    }
}

// Функция заполнения массива случайными числами
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

// Функция сортировки массива по убыванию
void OrderArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}