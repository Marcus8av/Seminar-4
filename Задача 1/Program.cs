/* Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
Для решения задания использование цикла for является обязательным условием.*/

System.Console.WriteLine("Введите число A");
int Number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B");
int Number2 = Convert.ToInt32(Console.ReadLine());

int a = Number1;

for (int i = 1; i < Number2; i++)
{
Number1 = Number1 * a;
}

System.Console.WriteLine($"Натуральное число в степени равно {Number1}.");

System.Console.WriteLine();
