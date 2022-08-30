//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
      for(int j = 0; j < matr.GetLength(1); j++)
        {
          Console.Write($"  |{matr[i, j]}|  ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
      for(int j = 0; j < matr.GetLength(1); j++)
        {
          matr[i, j] = new Random().Next(0, 10);
        }
    }
}

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine("Средние арифметические: ");
for(int j = 0; j < matrix.GetLength(1); j++)
    {
      double srArm = 0;
      for(int i = 0; i < matrix.GetLength(0); i++)
        {
            srArm = srArm + matrix[i, j];
        }
    Console.Write($" + {Math.Round(srArm / matrix.GetLength(0), 2)}");
    }
Console.WriteLine();


