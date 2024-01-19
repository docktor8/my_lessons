using System;

// Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

void Cicl()
    {
        string? control = "";
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
                    Console.WriteLine(c);
                    Console.WriteLine(sum);
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
Cicl ();



