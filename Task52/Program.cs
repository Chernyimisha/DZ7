// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

int[,] array2D = CreateMatrix(5, 8, 0, 20);
double[] arithmeticMeanElementsColumns = CalcArithmeticMean(array2D);
Console.WriteLine("Задан массив: ");
PrintMatrix(array2D);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(arithmeticMeanElementsColumns);

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "; ");
        else Console.WriteLine(arr[i] + ".");
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],3}, ");
            else Console.Write($"{matr[i, j],3}");
        }
        Console.WriteLine("]");
    }
}

double[] CalcArithmeticMean(int[,] matr)
{
    double[] result = new double[matr.GetLength(1)];
    int sumElementsColumns = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sumElementsColumns = sumElementsColumns + matr[i, j];
        }
        result[j] = (double)sumElementsColumns / matr.GetLength(0);
        result[j] = Math.Round (result[j],1);
        sumElementsColumns = 0;
    }
    return result;
}