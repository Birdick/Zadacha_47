// Задача 47. Задайте двумерный массив 
// размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

// matrix fullfilment

Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}
void PrintArray(int[,] matrix2D)
{
    for (int i = 0; i < matrix2D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2D.GetLength(1); j++)
        {
            Console.Write($"{matrix2D[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter the row quantity of your matrix: ");
int numM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the columns quantity of your matrix: ");
int numN = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the munimum number of your matrix: ");
int numMin = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the maximum number of your matrix: ");
int numMax = int.Parse(Console.ReadLine()!);
int[,] newMatrix = GetArray(numM, numN, numMin, numMax);
PrintArray(newMatrix);
