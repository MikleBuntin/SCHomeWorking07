// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];

void PrintArray(double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
      for(int j = 0; j < matr.GetLength(1); j++)
        {
          Console.Write($" |{matr[i, j]}| ");
        }
        Console.WriteLine();
    }
}
void FillArray(double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
      for(int j = 0; j < matr.GetLength(1); j++)
        {
          matr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

FillArray(matrix);
// PrintArray(matrix);

Console.WriteLine("Введите позицию элемента массива: ");
Console.WriteLine("Строка: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Столбец: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a < matrix.GetLength(0) & b < matrix.GetLength(1))
{
    Console.WriteLine($"Элемент  {a}, {b}: {matrix[a, b]}");
}
else Console.WriteLine("Такого элемента нет!");
