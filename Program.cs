﻿// Задача 1. Напишите программу которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя)


// Console.WriteLine("vvedite chislo: ");
// int number = Convert.ToInt32(Console.ReadLine()); // tip_dannyh imya = znachenie;
// int result = number * number;
// Console.WriteLine(result);
// Console.WriteLine();


// Задача 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет


// Console.WriteLine("Введите первое число: "); // текст подсказка которая помогает получить первое число
// int firstNumber = Convert.ToInt32(Console.ReadLine());  

// Console.WriteLine("ВВедите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

//     if (secondNumber * secondNumber == firstNumber)
//     {   Console.WriteLine("первое число Является квадратом второго");

//     }
//     else 
//     Console.WriteLine("первое число НЕ является квадратом второго");


// Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница


// int dayNumber = Convert.ToInt32(Console.ReadLine());
// if (dayNumber == 1) Console.WriteLine("Понедельник");


// Задача 5. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"


// Console.WriteLine("Введите число N: ");
// int positiveNumber = Convert.ToInt32(Console.ReadLine()); // N
// if (positiveNumber < 0) positiveNumber*= -1; // из отрицательного числа делает положительное
// int negativeNumber = positiveNumber * (-1);

// while (negativeNumber <= positiveNumber) //пока условие истинно
// {
//     System.Console.Write(negativeNumber + " ");
//     negativeNumber++;

// }
// 
// Практическое задание 1.

// Задача 2. Напишите программу, которая на вход принимает два числа
// и выдает какое число большее, а какое меньшее

// Console.Clear();

// Console.WriteLine("Введите первое число: ");

// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");

// int secondNumber = Convert.ToInt32(Console.ReadLine());
// if (firstNumber == secondNumber)
//     {
//         Console.WriteLine("Числа равны");
//     }

//     else if (firstNumber < secondNumber)
//     {
//     Console.WriteLine(secondNumber + " " + "наибольшее число");
//     Console.WriteLine(firstNumber + " " + "наименьшее число");
//     }
//     else
//     {
//     Console.WriteLine(firstNumber + " " + "наибольшее число");
//     Console.WriteLine(secondNumber + " " + "наименьшее число");
//     }

//  git commit -am "Напишите программу, которая на вход принимает два числа и выдает какое число большее, а какое меньшее"

// Задача 4. Напиште программу, которая на вход принимает три числа и выдаёт максимальное из этих чисел
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Clear();
// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третье число: ");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());

// if ((firstNumber > secondNumber) & (firstNumber > thirdNumber))
// {
//     System.Console.WriteLine(firstNumber + " " + "наибольшее число");
// }
// else if (secondNumber > thirdNumber)
//     System.Console.WriteLine(secondNumber + " " + "наибольшее число");
// else 
//     System.Console.WriteLine(thirdNumber + " " + "наибольшее число");



// Задача 6.Напишите программу, которая на вход принимает число и выдаёт,
//  является ли число чётным (делитлся ли оно на два без остатка).    

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number %2 == 1)

// {
//      Console.WriteLine("нечетное число");    
// }
// else Console.WriteLine("четное число");



// Задача 8. Напишите программу, которая на вход приничиет число (N), 
// а на выходе показывает все четные числа от 1 до N 

// Console.Clear();

// Console.WriteLine("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());
// while (number > 1)
// {
//     if (number % 2 == 0)

//     {
//         Console.WriteLine($"Четное значение из задоного вами набора чисел = {number}");
//         number--;
//     }
//     else
//     {
//         number--;
//     }

// }

// Begin_1. Напишите программу для вывода своих фамилии, имени и отчества на каждой новой строке.

// {   Console.Clear(); // очищает терминал
//     System.Console.WriteLine("Andrey");
//     System.Console.WriteLine("Shulzhenko"); 
//     Console.ReadKey(); // заставляет консоль перед закрытием окна, ждать нажатия клавиши

// }

// Begin_2

// Вывести на экран пять строк из нулей, причем количество нулей в каждой строке равно номеру строки. Использовать только Console.Write().

// Пример использования:
// Выходные данные 1: 0
// Выходные данные 1: 00
// Выходные данные 1: 000
// Выходные данные 1: 0000
// Выходные данные 1: 00000

// {
//     Console.Clear();
//     //Console.Write("0\n00\n000\n0000\n00000"); // "\n" - перенос на новую строку [хреновочитаемый код, тоже работает, но когда всё в кучу]

//     Console.Write("0\n" + 
//                   "00\n" +  //удобочитаемый код
//                   "000\n" + 
//                   "0000\n" + 
//                   "00000\n"); 
//     Console.ReadKey();
// }

// Begin_5

// Вывести на одной строке числа 5, 11, 1025 через пробел. Примечание: правильных ответов может быть несколько.

// {
//     Console.Clear();
//     Console.WriteLine("var1.");
//     Console.Write(5 + " 11 1025");
//     Console.WriteLine();
//     Console.WriteLine("var2.");
//     Console.Write("5 11 " + 1025);
//     Console.WriteLine();
//     Console.WriteLine("var3.");
//     Console.Write(5 + " " + 11 + " " + 1025);
//     Console.WriteLine();
//     Console.WriteLine("var4.");
//     Console.WriteLine("5 11 1025");
//     Console.WriteLine();
//     Console.WriteLine("var5.");
//     Console.WriteLine(5 + " " + 11 + " " + 1025);
//     Console.WriteLine();
//     Console.WriteLine("var6.");
//     Console.Write("5 11 1025");
//     Console.ReadKey();
// }
// Home_1. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними
// {
//     Console.Clear();
//     Console.Write(5 + " " + " " + 11 + " " + " " + 1025);
//     Console.ReadKey();
// }

// Home_2. Составить программу вывода на экран в одну строку четырех любых чисел с одним пробелом между ними.

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         {
//             Random rd = new Random();        // "любых чисел"... хм... 
//             int rand_num1 = rd.Next(1, 200);
//             int rand_num2 = rd.Next(1, 200);
//             int rand_num3 = rd.Next(1, 200);
//             int rand_num4 = rd.Next(1, 200);
//             Console.Clear();
//             Console.Write(rand_num1 + " " + rand_num2 + " " + rand_num3 + " " + rand_num4 + " ");
//             Console.ReadKey();
//         }
//     }
// }






// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int GetSum(int A ) 
// { // инт - функция будет возвращать целое число, GetSum - название, переменная А будет работать только внутри функции
//     int sum = 0;

//     for (int i = 1; i <= A; i++)
//     {
//         sum+= i;
//     }
//     return sum;
// }
// Console.Clear();
// Console.Write("Введите число A: ");
// int N = int.Parse(Console.ReadLine()!); 
// Console.WriteLine(GetSum(N));

// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 


// int NumberDigit(int number)
// {
//     int count = 0;
//     while (number > 0)
//     {
//         number = number / 10;
//         count++;
//     }
//     return count;
// }

// Console.WriteLine("Vvedite chislo: ");
// int N = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine(NumberDigit(N));

// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// int Mutli(int A ) 
// { 
//     int prod = 1;

//     for (int i = 1; i <= A; i++)
//     {
//         prod*= i;
//     }
//     return prod;
// }
// Console.Clear();
// Console.Write("vvedite chislo A: ");
// int N = int.Parse(Console.ReadLine()!); 
// Console.WriteLine(Mutli(N));

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Int GetArray ();
// int n = 8;
// int[] array = new int[n];
// Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(0,2);
// }
// return array;
// var str = string.Join(", ", GetArray());
// Console.WriteLine("[" + str + "]");

// int[] GetArray()
// {
//     int[] array = new int[8];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//     }

//     return array;
// }
// var str = string.Join(", ", GetArray());
// Console.WriteLine("[" + str + "]");