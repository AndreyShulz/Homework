
// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B. Реализовать функцию возведения в степень
// самостоятельно!


// int MyMathPow(int num, int pow)
// {
//     int result = 1;
//     if (pow > 0)
//     {
//         for (int i = 1; i <= pow; ++i)
//         {
//             result *= num;
//         }
//     }
//     else if (pow < 0)
//     {
//         for (int i = -1; i >= pow; --i)
//         {
//             result /= num;
//         }
//     }
//     return result;
// }
// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите желаемую степень: ");
// int pow = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Результат = {MyMathPow(num,pow)}");


// Задача 27: Напишите функцию и запустите ее, которая
// принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int SumOfDigits()
// {
//     Console.WriteLine("Введите число: ");
//     int sum = 0, num = Convert.ToInt32(Console.ReadLine());
//     while (num > 0)
//     {
//         sum += (num % 10); //sum = sum + (num % 10);
//         num /= 10; //num = num / 10;
//     }
//     return sum;
// }
// Console.Clear();
// Console.WriteLine($"\nЗадача 27. Сумма цифр в числе");
// Console.WriteLine("Сумма цифр в числе {0}", SumOfDigits()); 

// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.

// Console.Write("Введите количество элементов массива: \t"); // \t - табуляция в строке консоли

// int elementsCount = int.Parse(Console.ReadLine()!);      
// int[] myArray = new int[elementsCount]; 

// int[] myArray = new int[8];
// for (int i = 0; i < myArray.Length; i++)
// {
//     Console.Write($"Введите элемент массива под индексом: {i} \t"); // знак доллара чтобы читалось то, что в фигурных скобках
//     myArray[i] = int.Parse(Console.ReadLine()!); // восклицательный знак для того, чтобы игнорировать warning
// }
// Console.WriteLine("Вывод массива");
// for (int i = 0; i < myArray.Length; i++)
// {
//     Console.WriteLine(myArray[i]);
// }
// Console.ReadLine();