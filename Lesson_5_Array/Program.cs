using System;
using System.ComponentModel;
//Задание 1
int[] arr = new int[5];
arr[0] = 4;
arr[1] = 5;
arr[2] = 100;
arr[3] = 1;
arr[4] = 2;
Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);
Console.WriteLine(arr[3]);
Console.WriteLine(arr[4]);
//Console.WriteLine(arr[5]);

int[] arr2 = new int[5] { 1, 3, 7, 6, 8 };

int[] arr3 = { 1, 100, 7, 9, 4 };

//ЗАдание 2
int n = 8;
int[] arr1 = new int[n];
int i = 0;

while (i < arr1.Length)
{
    arr1[i] = i + 1;
    //Console.Write(arr[i]);
    //Console.Write('');
    Console.Write($"{arr1[i]} ");
    i = i + 1;
}
Console.WriteLine("");

//Задача 3
int num = 10;
int[] arr4 = { 2, 5, 978, 5, 98, 5, 65, 85, 65, 8552 };
int c = 0;

while (c < num)
{
    if (arr4[c] % 2 == 0)
    {
        Console.Write($"{arr4[c]} ");
        
    }
    c++;
}
Console.WriteLine("");

//Задача 4

int numGir = 10;
int[] arr5 = { 2, 5, 978, 5, 98, 5, 65, 85, 65, 8552 };
int a= 0;
int max = arr5[0];

while (a < numGir)
{
    if (arr5[a] > max)
    {
        max = arr5[a];
        
        
    }
    a++;
}
Console.Write($"{max}");
Console.WriteLine("");
//Задача 5
int numGir1 = 10;
int[] arr6 = { 2, 5, 978, 5, 98, 5, 65, 85, 65, 8552 };
int max1 = arr6[0];

for (i=0; i < numGir1; i++)
{
    if (arr6[i] > max1)
    {
        max1 = arr6[i];
        
        
    }
   
}
Console.WriteLine($"{max1}");

max1 = arr6[0];
foreach(int ar in arr6)
{
    if (ar> max1)
    {
        max1 = ar;
               
    }
}
Console.Write($"{max1}");
