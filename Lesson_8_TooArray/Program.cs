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

/* int[,] GretMatrix(int rowCount, int cntolumnCout)
{
    int[,] matrix = new int[rowCount, cntolumnCout];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = rnd.Next(1, 1000);
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

int[,] matrix = GretMatrix(4, 5);
ShouMatrix(matrix);
//ShouMatrix(matrix);
foreach (int e in matrix)
{
    if (IsInteresting(e))
    {
        Console.WriteLine(e);
    }
}

bool IsInteresting(int value)
{
    int sum = GetSum(value);
    if (sum % 2 == 0)
    {
        return true;
    }
    return false;
}

int GetSum(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}
 */
string GetLetters(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (Char.IsLetter(e))
        {
            letters = letters + e;
        }
    }
    return letters;
}
string str = Console.ReadLine();
string result = GetLetters(str);
Console.WriteLine(result);