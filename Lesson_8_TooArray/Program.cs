using System;
Random rnd = new Random();
//int[,] matrix = new int[3, 5];
/* for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        matrix[i, j] = rnd.Next(1, 11);
    }
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
} */

int[,] GretMatrix(int rowCount, int cntolumnCout)
{
    int[,] matrix = new int[rowCount, cntolumnCout];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShouMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GretMatrix(4,5);
ShouMatrix(matrix);
