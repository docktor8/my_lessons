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

int[] arr2 = new int[5] {1, 3, 7, 6, 8};

int[] arr3 = {1, 100, 7, 9, 4};

//ЗАдание 2
int n =8;
int[] arr1 = new int[n];
int i = 0;

while(i<arr1.Length)
{
    arr1[i] = i+1;
    //Console.Write(arr[i]);
    //Console.Write('');
    Console.Write($"{arr1[i]} ");
    i=i+1;
}
