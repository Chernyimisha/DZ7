// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента
// в массиве нет

Console.WriteLine("Укажите положение элемента по вертикали: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите положение элемента по горизонтали: ");
int y = Convert.ToInt32(Console.ReadLine());

int rows = new Random().Next(1, 5);
int columns = new Random().Next(1, 5);
int[,] matrix = new int[rows, columns];
CreateMatrix(matrix);

if (x > 0 && y > 0)
{
    Console.WriteLine("Задан массив: ");
    PrintMatrix(matrix);
    if (x <= rows && y <= columns)
    {
        //учитывая, что пользователь скорее всего будет считать элементы с индексом ноль    
        //первой строкой или первым столбцом, искать по факту будем matrix[x - 1, y - 1]
        
        Console.WriteLine($"{x},{y} -> искомый элемент равен {matrix[x - 1, y - 1]}");
    }
    else Console.WriteLine($"{x},{y} -> такого элемента в массиве нет");
}
else Console.WriteLine("Заданы некорректные координаты элемента");

void CreateMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-99, 100);
        }
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
