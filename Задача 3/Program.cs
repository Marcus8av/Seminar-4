﻿/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
Заполнение массива производит пользователь.*/

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
System.Console.WriteLine($"Введите элемент {i + 1}:");
array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
System.Console.WriteLine($"Массив равен({i})={array[i]} ");
}
