/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
Для решения задания использование цикла for является обязательным условием*/

System.Console.WriteLine("Введите число:");
string Number = Console.ReadLine();
int summ = 0;
int Number1 = Convert.ToInt32(Number);

for (int i = 0; i < Number.Length - 1; i++)
{
summ = summ + Number1 % 10;
Number1 = Number1 / 10;
}

summ = summ + Number1;

System.Console.WriteLine("Сумма цифр в числе: " + summ);
