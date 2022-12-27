// 25.12.2022 

// способ заполнения двумерного массива одним циклом. выйгрыш в количестве строк кода и нашего времени 

// int rows = 2;
// int columns = 2;
// int[,] array = new int[2, 2]; // 2 строчки 2 столбца
// Random rand = new Random();

// for (int i = 0; i < rows * columns; i++) // можно и трёхмерный массив, но нужно i < rows * columns умножить ещё на одно измерение * Z (условно) ... но это не точно :)
// {
//     array[i / columns, i % columns] = rand.Next(11); // [0-10]
// }
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         Console.Write(array[i,j]+ "\t");
//     }   
//     Console.WriteLine(); 
// }


// ============================ продолжаем работу с рекурсией ===============================

// напомним, что рекурсия - это метод, который вызывает сам себя
// вызовем stack overflow для разминки:

// string SayHello()
// {
//     System.Console.WriteLine("Hi");
//     return SayHello();
// }
// Console.WriteLine(SayHello());

// факториал с помощью рекурсии

// int Factorial(int number) // number число от которого ищется факториал
// {
//     // базовый случай - выходите из рекурсии, рекурсия = бесконечный цикл без базового случая

//     if (number == 1)
//     {
//         return 1;
//     }
//     // рекурсивный случай
//     // number = 5 * 4 * 3 * 2 * 1 
// else return number * Factorial(number - 1);  // else можно не писать
// }
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Factorial(num));

// решение задач в группах

// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// // start == 1; end == N
// string PrintNumbers(int start, int end)
// {   
//         // базовый случай
//     if (start == end) return start.ToString();
//         // рекурсивный случай
//     return (start + ", " + PrintNumbers(start +1, end));
// }
// Console.WriteLine(PrintNumbers(1,n));


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


// Console.WriteLine("Введите число: ");
// int digit = Convert.ToInt32(Console.ReadLine());

// int SumOfDigits(int number)
// {
//     // basic case
//     if (number == 0) return number;
//     // recursive case
//     return (number % 10) + SumOfDigits(number / 10);
// }
// Console.WriteLine($"сумма цифр в числле {digit} = {SumOfDigits(digit)}");


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите степень: ");
// int degree = Convert.ToInt32(Console.ReadLine());

// int Pow(int num, int power)
// {   
//     if (power == 0) return 1;
//     if (power == 1) return num;
//     // recursive case
//     return (num * Pow(num, power - 1)); // power - это грубо говоря счётчик (степень)
    
// }
// Console.WriteLine($"результат = {Pow(number, degree)}");

// ================================== DZ ==================================  
// Практическое задание 9. Practice 9. Practice009.

// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

// Console.WriteLine("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// // start == 1; end == N
// string PrintNumbers(int start, int end)
// {   
//         // базовый случай
//     if (start == end) return start.ToString();
//         // рекурсивный случай
//     return (start + ", " + PrintNumbers(start +1, end));
// }
// Console.WriteLine(PrintNumbers(m,n));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int GetSumInInterval (int start, int end)
// {
//     if (start == end) return start;
//     return end + GetSumInInterval(start, end - 1);
// }
// Console.WriteLine($"сумма натуральных элементов в промежутке равна: {GetSumInInterval(m,n)}");



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Введите число m: ");
int mm = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int nn = Convert.ToInt32(Console.ReadLine());

int funAkkerman(int m, int n)
{
   if (m == 0) return n + 1;
   else if (n == 0) return funAkkerman (m - 1, 1);
   else return funAkkerman(m - 1, funAkkerman (m, n - 1));
}
Console.WriteLine(funAkkerman(mm,nn));
