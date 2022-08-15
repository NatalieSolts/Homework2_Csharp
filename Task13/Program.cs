// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Решить без использования строк.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number > 99 && number < 1000) Console.WriteLine(number % 10);  // 3х-значное

else if (number > 999 && number < 10000) Console.WriteLine(number / 10 % 10); // 4х-значное
else if (number > 9999 && number < 100000) Console.WriteLine(number / 100 % 10); // 5-значное
else if (number > 99999 && number < 1000000) Console.WriteLine(number / 1000 % 10); // 6-значное
else if (number > 999999 && number < 1000000 * 10) Console.WriteLine(number / 10000 % 10); // 7-значное
else if (number > 9999999 && number < 1000000 * 100) Console.WriteLine(number / 100000 % 10); // 8-значное
else if (number > 99999999 && number < 1000000 * 1000) Console.WriteLine(number / 1000000 % 10); // 9-значное
else if (number > 1000000 * 1000) Console.WriteLine("Введите число поменьше, плиззззз");
else if (number < -99 && number > -1000) Console.WriteLine(-number % 10);  // отрицательное 3х-значное
else if (number < -999 && number > -10000) Console.WriteLine(-number / 10 % 10); // 4х-значное
else if (number < -9999 && number > -100000) Console.WriteLine(-number / 100 % 10); // 5-значное
else if (number < -99999 && number > -1000000) Console.WriteLine(-number / 1000 % 10); // 6-значное
else if (number < -999999 && number > -1000000 * 10) Console.WriteLine(-number / 10000 % 10); // 7-значное
else if (number < -9999999 && number > -1000000 * 100) Console.WriteLine(-number / 100000 % 10); // 8-значное
else if (number < -99999999 && number > -1000000 * 1000) Console.WriteLine(-number / 1000000 % 10); // 9-значное
else if (number >= -99 && number < 99)Console.WriteLine("Третьей цифры нет");
else Console.WriteLine ("Введите другое число, плиззззз");