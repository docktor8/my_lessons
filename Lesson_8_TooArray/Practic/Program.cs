using System;

// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.
// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
/* Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. 
В полученной строке слова должны быть также разделены пробелами. */

char[,] arr_char = { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };
string str = "И поэтому все так произошло";

// Функция создающая строку из массива символов
string GetLetters(char[,] arr_char)
{
    string letters = "";
    foreach (char e in arr_char)
    {
        letters = letters + e;
    }
    return letters;
}

// Функция меняющая заглавные буквы на строчные
string FormStrUppLow(string str)
{
    string str_low = str.ToLower();
    return str_low;
}

// Функция прверяющая строку на палиндромность
bool FindPalindr(string str)
{
    bool palind = false;
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] == str[str.Length - 1 - i])
        {
            palind = true;
        }
        else
        {
            palind = false;
            break;
        }
    }
    return palind;
}

// Функция меняющая расположение слов
string FormStrRevers(string str)
{
    string str_rev = "";
    string[] words = str.Split(new char[] { ' ' });
    for (int i = (words.Length - 1); i >-1; i--)
    {
        str_rev += words[i] + " ";
    }
    return str_rev;
}
string result = FormStrRevers(str);
Console.WriteLine(result);