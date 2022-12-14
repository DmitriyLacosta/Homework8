// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine();
Console.WriteLine("Программа, которая находит произведение двух матриц. С одинаковым количеством строк и столбцов.");
Console.WriteLine();

Console.Write("Введите число строк первой матрицы: ");
int rowsOfFirst = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов первой матрицы: ");
int columnsOfFirst = int.Parse(Console.ReadLine()!);

Console.Write("Введите число строк второй матрицы: ");
int rowsOfSecond = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов второй матрицы: ");
int columnsOfSecond = int.Parse(Console.ReadLine()!);

if (columnsOfFirst != rowsOfSecond) Console.WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы!");
else
{
    int[,] firstArray = GetArray(rowsOfFirst, columnsOfFirst);
    Console.WriteLine("Первый массив:");
    PrintArray(firstArray);
    Console.WriteLine();

    int[,] secondArray = GetArray(rowsOfSecond, columnsOfSecond);
    Console.WriteLine("Второй массив:");
    PrintArray(secondArray);
    Console.WriteLine();

    int[,] thirdArray = GetMultiplicationOfMatrix(firstArray, secondArray);
    Console.WriteLine("Результирующая матрица: ");
    PrintArray(thirdArray);
}




int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random random = new Random((int)DateTime.Now.Ticks);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,4}", array[i, j]));
        }
        Console.WriteLine();
    }
}

int[,] GetMultiplicationOfMatrix(int[,] firstArray, int[,] secondArray)
{
    int[,] thirdArray = new int[rowsOfFirst, columnsOfSecond];
    for (int i = 0; i < rowsOfFirst; i++)
    {
        for (int j = 0; j < columnsOfSecond; j++)
        {
            for (int k = 0; k < columnsOfFirst; k++)
            {
                thirdArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    return thirdArray;
}