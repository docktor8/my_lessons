using System;

//  Задание 1 Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

void Cicl()
    {
        string control = "";
        bool num = false;
        while (num == false)
        {
            Console.WriteLine("Введите целое число");
            control = Console.ReadLine();
            num = int.TryParse(control, out var number);
            int sum = 0;
            if (num)
            {
                foreach(char c in control)
                {
                    sum += (int)Char.GetNumericValue(c);
                }
                if (sum%2 != 0)
                {
                    num = false;
                }
            }
            else if (control== "q")
            {
                num=true;
            }
        }
    }
//Cicl ();

//Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int [] Arr(int len, int min, int max)//Функция возращающая одномерный массив по его длине
{
    int [] arry = new int[len];
    for (int i = 0; i < len; i++)
    {
        arry[i] = new Random().Next(min,max);
        Console.WriteLine($"{arry[i]} ");
    }
    Console.WriteLine();
    return arry;
}
void NumCol(int[] arry)
{
    int col = 0;
    foreach(int e in arry)
    {
        if(e%2==0)
        {
            col+=1;
        }
    }
    Console.WriteLine(col);
}

//Console.WriteLine("Введите размер массива:");
//int len = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите введите минимальное число массива массива:");
//int min = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите введите максимальное число массива массива:");
//int max = int.Parse(Console.ReadLine());
//int [] arry = Arr(len, min, max);
//NumCol (arry);

//Задача 3:Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9. Сформируйте целое число, которое будет состоять из цифр из массива. 
//Старший разряд числа находится на 0-м индексе, младший – на последнем.

Console.WriteLine("Введите размер массива:");
int len = int.Parse(Console.ReadLine());
Console.WriteLine("Введите введите минимальное число массива массива:");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите введите максимальное число массива массива:");
int max = int.Parse(Console.ReadLine());
int [] arry = Arr(len, min, max);
void NumArr(int [] arry)
{
    int num = 0;           
    for (int i = 0; i<arry.Length; i++)
    {
        num *=10;
        num += arry[i];
    }
    Console.WriteLine(num);
}
NumArr(arry);