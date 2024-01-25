using System;

/* Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.
Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы. */

//Функция выводящия числа из интервала
void OutNatRang(int min, int max)
{
    {
        if (max < min) return;
        OutNatRang(min, max - 1);
        Console.Write($"{max}, ");
    }
}

// Функция ставящая первое число минимальным и передает их на вывод
void OutNatRangMinMax(int m, int n)
{
    int min = m;
    int max = n;
    if (min > n)
    {
        min = n;
        max = m;
    }
    OutNatRang(min, max);
}

// Функция Аккермана
int FukcAkker(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0)
    {
        if (m == 0) return n + 1;
        return FukcAkker(m - 1, 1);
    }
    return FukcAkker(m - 1, FukcAkker(m, n-1));
}

//Функция выводящая элементы массива с конца
void PrintElemEnd(string [] array)
{
    Console.Write($"{array[array.Length-1]} ");
    if (array.Length == 1) return;
    string str = string.Join(" ", array);
    char ch = ' ';
    int indexOfChar = str.LastIndexOf(ch);
    string[] words = str.Substring(0, indexOfChar).Split(new char[] { ' ' });
    PrintElemEnd(words);
    
}
// OutNatRangMinMax(5, 2);
//int akker = FukcAkker(3,2);
//Console.Write(akker);
string[] array = {"1", "25", "36", "58"};
PrintElemEnd(array);
/* string str = string.Join(" ", array);
char ch = ' ';
int indexOfChar = str.LastIndexOf(ch);
string[] words = str.Substring(0, indexOfChar).Split(new char[] { ' ' });
foreach (string i in words)
{
    Console.WriteLine(i);
} */