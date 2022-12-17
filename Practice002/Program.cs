// Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

// int number = new Random ().Next(10,100);
// int firstDigit = number / 10; // первая цифра числа 78 -> 7 
// int secondDigit = number % 10; // вторая цифра числа: 78 -> 8
// int max = firstDigit; // Пусть максимум - первая цифра числа

// if (secondDigit > max) //max = 5, second digit = 10
// {
//     max = secondDigit;
// }
// Console.Clear();
// Console.WriteLine("Исходное число: " + number);
// Console.WriteLine("Максимальное число: " + max);


// Задача 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// int number = new Random ().Next(100,1000); // 100 - 999
// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// Console.WriteLine("исходное число: " + number);
// int result = firstDigit * 10 + thirdDigit;
// Console.WriteLine("результат: " + result); 



// Задача 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, 
// то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.WriteLine("enter firsts number: ");

// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("enter second number:");

// int secondNumber = Convert.ToInt32(Console.ReadLine());

// int result = firstNumber % secondNumber;

// if (result > 0)

//     Console.WriteLine("не кратно, остаток " + result);
//     else 
//     Console.WriteLine("кратно");

// Задача 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.WriteLine("enter number: ");
// int Number = Convert.ToInt32(Console.ReadLine());

// if (Number % 7 == 0 && Number % 23 == 0)
// Console.WriteLine("yes");
// else
// Console.WriteLine("no");

// Практическое задание 2.

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.Clear();
// Console.WriteLine("Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string stringIndex = Convert.ToString(number);
// Console.WriteLine("вторая цифра: " + stringIndex[1]);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.Clear();
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string stringIndex = Convert.ToString(number);
// if (stringIndex.Length > 2 ) // Если сделать stringIndex.Leght < 2 и вывод "третьей цифры нет" почему-то пишет ошибку, что .. 
// Console.WriteLine("третья цифра: " + stringIndex[2]); // .. искомое число за пределами массива
// else 
// Console.WriteLine("третьей цифры нет");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


// Console.Clear();
// Console.WriteLine("Введите число, обозначающее день недели от 1 до 7: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number == 7 || number == 6) Console.WriteLine("да"); // "||"оператор ИЛИ 
// else if (number < 1 || number > 7)
//     Console.WriteLine("ошибка ввода");
// else
//     Console.WriteLine("нет");
// Console.Beep();