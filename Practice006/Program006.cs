// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] tempArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         tempArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return tempArray;
// }
// int[] array = GetArray(6, 0, 10); // Массив на 6 элементов от 0 до 10

// /// 1. Запись массива справо - налево. поэлементное копирование
// int[] CopyReverseArray(int[] array)
// {
//     int size = array.Length; 
//     int[] result = new int[size]; // Копия - такой же размер
//     int last = size - 1;
//     for (int i = 0; i < size; i++) // i++ - слево - направо
//     {
//         result[i] = array[last - i]; // Последний элемент - текущий
//     }
//     return result;
// }
// Console.WriteLine(String.Join("; ", array));

// Console.WriteLine($"Copy: {String.Join(", ", CopyReverseArray(array))}");


// /// 2. Метод пузырька
// void BubbleSort(int[] array)
// {
//     int size = array.Length;
//     int last = size - 1;
//     for (int i = 0; i < size / 2; i++)
//     {
//         int temp = array[i]; //temp = a[0,], temp = 1
//         array[i] = array[last - i]; // a[0] = a[3] =>
//         array[last - i] = temp; // temp = 1, a[3] = 1 => {4,2,3,1}
//     }
// }
// BubbleSort(array);
// Console.WriteLine($"Bubble: {String.Join(", ", array)}");


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон


// int a = 2;
// int b = 3;
// int c = 4; // эти переменные можно удалить и ввести значения сразу в выводе

// bool IsTriangle(int a, int b, int c)
// {
//     return ((a + b) > c && (a + c) > b && (b + c) > a);
// }
// Console.WriteLine(IsTriangle(a,b,c));   // вот так: Console.WriteLine(IsTriangle(10000,5,4));  


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// /// "арифметический" метод решения 

// int firstElement = 0;
// int secondElement = 1;
// int number = 8; // количество чисел Фибоначчи 0, 1, 1, 2
// Console.WriteLine($"1 элемент: {firstElement} ");
// Console.WriteLine($"2 элемент: {secondElement} ");

// for (int i = 3; i <= number; i++)
// {
//     int nextElement = firstElement + secondElement; // next = 0 + 1 == 1
//     Console.WriteLine($"{i} элемент: {nextElement} ");
//     firstElement = secondElement;
//     secondElement = nextElement;
// }

// ================================== DZ ==================================  
// Практическое задание 6. Practice 6. Practice006.


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите числа через запятую: ");
// int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"{count} чисел больше нуля Вы ввели");



// Задача 42: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями: 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// #: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите числа через запятую: ");
int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

double[] PointOfStraightLines(int[] array)
{
    double x,y = 0;
    double b1 = array[0];
    double k1 = array[1];
    double b2 = array[2];
    double k2 = array[3];

    x = b2 / (k1-k2) - b1 / (k1-k2);
    y = k2 * x + b2;

    double[] result = {x,y};
    return result;
}
double[] arrayResult = PointOfStraightLines(array);
Console.WriteLine($"Координаты точки пересечения прямых: ({arrayResult[0]};{arrayResult[1]})");

// Задача 43 (ДОП, по желанию, на 5 нужно сделать 2 задачки): Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10