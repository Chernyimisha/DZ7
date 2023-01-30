// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] matrix = CreateMatrixRndDouble(5, 8, -100, 100);
Console.WriteLine($"m = {matrix.GetLength(0)}, n = {matrix.GetLength(1)}");
PrintMatrix(matrix);

double[,] CreateMatrixRndDouble(int rows, int columns, double min, double max)
{
    double[,] arr = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            double num = rnd.NextDouble()*(max - min) + min;
            arr[i,j] = Math.Round(num,1);
        }  
    }
    return arr;
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j<matr.GetLength(1)-1) Console.Write($"{matr[i, j], 5}, ");
            else Console.Write($"{matr[i, j],5}");
        }
        Console.WriteLine("]");
    }
}