// Задача 10: Напишите программу, которая 
// принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа. 
// Решить без использования строк.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write ("Введите трёхзначное число: ");
int number = Convert.ToInt32 (Console.ReadLine());
int secondDigit = number / 10 % 10; 
// избавляемся от последней цифры, разделив нацело на 10, 
// а потом от первой, найдя остаток от деления на 10

if (number < -99 && number > -1000) 
{
    secondDigit = -1 * secondDigit;
    Console.WriteLine($"Убираем первую и третью циферки и получаем: {secondDigit}");
}
else if (number >= -99 && number <= 99 || number < -999 || number > 99 ) 
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}
 else Console.WriteLine($"Убираем первую и третью циферки и получаем: {secondDigit}");