// Урок 3. Базовые алгоритмы. Продолжение

// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.Write("Введите первое число > ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число > ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x>0 && y>0)
// {
//     Console.WriteLine("Точка в первой четверти");
// }
// else if (x<0 && y>0) Console.WriteLine("Точка во второй четверти");
// else if (x<0 && y<0) Console.WriteLine("Точка в третьей четверти");
// else if (x>0 && y<0) Console.WriteLine("Точка в четвертой четверти");
// else Console.WriteLine("вы в начале координат!");


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21


// формула расстояния между точками М в 2д пространстве
// M1(x1; y1) и M2(x2; y2 ) 

// Console.WriteLine("Введите координату х1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату х2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());


// //double d = Math.Sqrt((x2-x1) * (x2-x1)) + ((y2-y1)*(y2-y1)) 
// // Math.Pow (2,3) => 8 = (2 * 2 * 2) 
// double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
// //Console.WriteLine("расстояние между двумя точками = " + Math.Round(d,3));
// Console.WriteLine($"Расстояние между двумя точками: {Math.Round(d,3)}"); // интерполяция


// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите число n: ");
// int finish = Convert.ToInt32(Console.ReadLine());

// int start = 1;

// while (start <= finish)
// {
//     Console.WriteLine(Math.Pow(start, 2));
//     start++;
// }

//тоже самое только с циклом фор

// Console.WriteLine("Введите число n: ");

// int finish = Convert.ToInt32(Console.ReadLine());

// for (int start = 1; start <= finish; start++;)
// { 
//     Console.WriteLine(Math.Pow(start,2) + " ");
// }



// ================================== DZ ==================================  
// Практическое задание 3. Practice 3. Practice003.

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Clear();
// Console.WriteLine("Введите пятизначное число: ");

// int number = Convert.ToInt32(Console.ReadLine());
// int number1 = number / 10000;
// int number22 = number % 10000;
// int number2 = number22 / 1000;
// int number44 = number % 100;
// int number4 = number44 / 10;
// int number5 = number % 10;
// if (number1 == number5 && number2 == number4)
// {
//     Console.WriteLine($"{number} - палиндром");
//     Console.Beep();
// }
// else Console.WriteLine($"{number} - не палиндром");




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Clear();
// Console.WriteLine("Введите координату х1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine("Расстояние между точками: " + Math.Round(d, 2));

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.WriteLine("Введите число N: ");
// int finish = Convert.ToInt32(Console.ReadLine());
// int start = 1;

// while (start <= finish)
// {
//     Console.WriteLine(Math.Pow(start, 3) + " ");
//     start++;
// }

