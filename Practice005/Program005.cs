// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9].
// Найдите сумму отрицательных и положительных элементов массива.

// int[] GetArray(int size, int minValue, int maxValue)

// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// int[] resultArray = GetArray(12, -9, 9);
// Console.WriteLine(String.Join(", ", resultArray));

// int resultPositive = 0;
// int resultNegative = 0;

// for (int i = 0; i < resultArray.Length; i++)
// {
//     resultPositive += resultArray[i] > 0 ? resultArray[i] : 0;
//     // resultArray[i] > 0(Истина) : resultPositive += resultArray[i];   // тернарный оператор
//     // resultArray[i] > 0(Ложь) : resultPositive += 0
//     resultNegative += resultArray[i] < 0 ? resultArray[i] : 0;
// }

// // for (int i = 0; i < resultArray.Length; i++)
// // {
// //     if (resultArray[i] > 0)
// //     {
// //         resultPositive += resultArray[i];
// //     }
// //     else resultNegative += resultArray[i];
// // }
// System.Console.WriteLine($"Сумма отрицательных чисел:{resultNegative} сумма положительных: {resultPositive}");


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// int[] GetArray(int size, int minValue, int maxValue)

// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// int[] resultArray = GetArray(12, -9, 9);


// int[] InverseArray(int[] array)
// {
//     int size = array.Length;
//     for (int i = 0; i < size; i++)
//     {
//         array[i] *= (-1); // array [i] = array[i] * (-1)
//     }
//     return array;
// }
// Console.WriteLine($"Array: [{String.Join(", ", resultArray)}]");
// Console.WriteLine($"Reversed Array: [{String.Join(", ", InverseArray(resultArray))}]");


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] array = { 1, 2, 3, 3, 5, 6, 7, 9 };
// int searchNumber = new Random().Next(1,11); // [1;10]
// Console.WriteLine($"ищем число {searchNumber} в массиве..");
// int size = array.Length;
// bool result = false;

// for (int i = 0; i < size; i++)
// {
//     if (searchNumber == array[i]) { 
//     result = true;
//     break;
//     }
// }
// // if (result == true)
// if (result) Console.WriteLine($"элемент {searchNumber} в массиве найден");   
// else Console.WriteLine($"элемент {searchNumber} в массиве не найден");   


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }


// int GetCountElements(int[] inputArray, int leftRange, int rightRange)

// {
//     int count = 0; // числа еще не искали :)
//     //foreach (тип_данных_и_переменную in массиве)
//     foreach (var item in inputArray)
//     {
//         if (item >= leftRange && item <=rightRange) count++; //item = inputArray[i]
//     }
//     return count;
// }

// int[] resultArray = GetArray(123, 0, 1000); // 123 элемента от 0 до 999 включительно
// Console.WriteLine($"Массив:[{String.Join(", ", resultArray)}]");
// Console.WriteLine($"Кол-во элементов в д-е [10;99]: {GetCountElements(resultArray, 10, 99)}");





// ================================== DZ ==================================  
// Практическое задание 5. Practice 5. Practice005.

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// int[] resultArray = GetArray(8, 100, 1000);
// Console.WriteLine($"Массив:[{String.Join(", ", resultArray)}]");

// int count  = 0;
// for (int i = 0; i < resultArray.Length; i++)
// {
//     if (resultArray[i] % 2 == 0) count++;
// }
// Console.WriteLine($"Кол-во чётных чисел в массиве: {count}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// int[] resultArray = GetArray(4, 1, 100);
// Console.WriteLine($"Массив:[{String.Join(", ", resultArray)}]");

// int sumOfElements = 0;
// for (int i = 1; i < resultArray.Length; i += 2)
// {
//     sumOfElements += resultArray[i];
// }
// Console.WriteLine($"Сумма эл-тов, стоящих на нечетных позициях = {sumOfElements}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// double[] test = new double[10];
// for (int i = 0; i < test.Length; i++)
// {
//     test[i] = Math.Round(new Random().NextDouble() * 1000, 3);
// }
// Console.WriteLine(String.Join(", ", test));


// double[] GetArray(int size, double minValue, double maxValue)
// {
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Math.Round(new Random().NextDouble() * 1000, 3);
//     }
//     return array;
// }
// double[] resultArray = GetArray(4, 1, 100);
// Console.WriteLine($"Массив:[{String.Join(", ", resultArray)}]");

// double max = resultArray[0];
// double min = resultArray[0];
// for (int i = 0; i < resultArray.Length; i++)
// {
//     if (resultArray[i] > max)
//     {
//         max = resultArray[i];   
//     }
//     else if (resultArray[i] < min)
//     {
//         min = resultArray[i];    
//     }
// }
// double difference = max - min;
// Console.WriteLine($"{max} - {min} = {Math.Round(difference, 3)}");



// Задача 37 со звездочкой, дополнительная: Найдите произведение (умножение) пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
int[] resultArray = GetArray(6, 1, 100);
Console.WriteLine($"Массив:[{String.Join(", ", resultArray)}]");

int size = resultArray.Length / 2; // 2 + 0/1
Console.WriteLine($"Половина длины массива = {size}"); 
int[] result = new int[size];


int first = 0; // Первый элемент из массива startArray
int last = resultArray.Length - 1; // 4 - индекс последнего элемента
int i = 0; // Индекс результирующего массива

while (last > first)
{
    result[i] = resultArray[first] * resultArray[last];
    i++; //  result[0],  result[1]
    first++;
    last--;
}
Console.WriteLine(String.Join(", ", result));
