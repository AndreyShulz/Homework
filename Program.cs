// Задача 1. Напишите программу которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя)


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


// Console.WriteLine("ВВедите первое число: "); // текст подсказка которая помогает получить первое число
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
// ==============================================================================================================================

// Задача 2. Напишите программу, которая на вход принимает два числа
// и выдает какое число большее, а какое меньшее

// Console.Clear();

// Console.WriteLine("Введите первое число: ");

// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");

// int secondNumber = Convert.ToInt32(Console.ReadLine());
// if (firstNumber == secondNumber)
//     {
//         System.Console.WriteLine("Числа равны");
//     }

//     else if (firstNumber < secondNumber)
//     {
//     System.Console.WriteLine(secondNumber + " " + "наибольшее число");
//     System.Console.WriteLine(firstNumber + " " + "наименьшее число");
//     }
//     else
//     {
//     System.Console.WriteLine(firstNumber + " " + "наибольшее число");
//     System.Console.WriteLine(secondNumber + " " + "наименьшее число");
//     }

//  git commit -am "Напишите программу, которая на вход принимает два числа и выдает какое число большее, а какое меньшее"

// 4.Напиште программу, которая на вход принимает три числа и выдаёт максимальное из этих чисел

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
// Console.WriteLine("нечетное число");    
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

// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
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
// System.Console.WriteLine("Исходное число: " + number);
// System.Console.WriteLine("Максимальное число: " + max);





// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// int number = new Random ().Next(100,1000); // 100 - 999

// int firstDigit = number / 100;

// int thirdDigit = number % 10;

// System.Console.WriteLine("исходное число: " + number);

// int result = firstDigit * 10 + thirdDigit;
// System.Console.WriteLine("результат: " + result); 



// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, 
// то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// System.Console.WriteLine("enter firsts number: ");

// int firstNumber = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("enter second number:");

// int secondNumber = Convert.ToInt32(Console.ReadLine());

// int result = firstNumber % secondNumber;

// if (result > 0)

//     System.Console.WriteLine("не кратно, остаток " + result);
//     else 
//     System.Console.WriteLine("кратно");

// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// System.Console.WriteLine("enter number: ");
// int Number = Convert.ToInt32(Console.ReadLine());

// if (Number % 7 == 0 && Number % 23 == 0)
// System.Console.WriteLine("yes");
// else
// System.Console.WriteLine("no");


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
// System.Console.WriteLine("Введите число, обозначающее день недели от 1 до 7: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number == 7 || number == 6) Console.WriteLine("да"); // "||"оператор ИЛИ 
// else if (number < 1 || number > 7)
//     System.Console.WriteLine("ошибка ввода");
// else
//     System.Console.WriteLine("нет");
// Console.Beep();


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


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
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


// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.WriteLine("Введите координату х1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату х2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.WriteLine("Введите число n: ");

// int finish = Convert.ToInt32(Console.ReadLine());
// for (int start = 1; start <= finish; start++;)
// { 
//     Console.WriteLine(Math.Pow(start,3) + " ");
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

