// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write ("Введите целое число от 1 до 7 включительно: ");
int weekday = Convert.ToInt32 (Console.ReadLine());

if (weekday == 6) Console.Write("Это суббота! ВЫХОДНОЙ!");
else if (weekday == 7) Console.Write("Это воскресенье! ВЫХОДНОЙ!");
else if (weekday < 7 && weekday >= 1) Console.Write("Это не выходной, а будний день!");
else Console.Write("Число не в диапазоне 1-7");