// 18.12.2022 Воскресенье. Двумерные массивы
// Урок 5. Функции и одномерные массивы

// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// 2 строчки, 3 столбца, int [rows, columns] 
// [,] кол-во запятых важно, 1 - двумерный масс, две - трёхмерный 
// m - колво строк, n - колво столбцов


// int[,] GetMatrix(int m, int n, int minValue, int maxValue)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) - индекс 0 - rows 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // j,m,k 
//                          // matrix.GetLength(1) = n, по столбцам
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1); 
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i,j] + "\t"); // 
//         }
//         Console.WriteLine(); // пустой врайтлайн, для переноса строчки
//     }
// }
// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] result = GetMatrix(rows, columns, 0, 10); // создали матрицу с элементами от 0 до 10

// // а теперь неотбходимо её напечатать
// PrintMatrix(result);



// Общее обсуждение

// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) - индекс 0 - rows 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // j,m,k 
//         // matrix.GetLength(1) = n, по столбцам
//         {
//             matrix[i, j] = i + j; 
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i,j] + "\t"); // 
//         }
//         Console.WriteLine(); // пустой врайтлайн, для переноса строчки
//     }
// }
// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] result = GetMatrix(rows, columns); 
// PrintMatrix(result);


// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.


// int[,] GetMatrix(int m, int n, int minValue, int maxValue)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) - индекс 0 - rows 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // j,m,k 
//         // matrix.GetLength(1) = n, по столбцам
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i,j] + "\t"); // 
//         }
//         Console.WriteLine(); // пустой врайтлайн, для переноса строчки
//     }
// }
// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] result = GetMatrix(rows, columns,0,10); 
// PrintMatrix(result);
// Console.WriteLine();;

// for (int i = 0; i < rows; i = i + 2)
// {
//     for (int j = 0; j < columns; j = j+2)
//     {
//         result[i, j] = result [i,j] * result[i,j];
//     }
// }
// PrintMatrix(result);


// ================================== DZ ==================================  
// Практическое задание 7. Practice 7. Practice007.



// Задача 51. найти сумму элементов главной диагонали

// int[,] GetMatrix(int m, int n, int minValue, int maxValue)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) - индекс 0 - rows 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // j,m,k 
//         // matrix.GetLength(1) = n, по столбцам
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t"); // 
//         }
//         Console.WriteLine(); // пустой врайтлайн, для переноса строчки
//     }
// }
// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] result = GetMatrix(rows, columns, 0, 10);
// PrintMatrix(result);
// Console.WriteLine(); 

// int sum = 0;
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         if (i == j)
//             sum = sum + result[i, j];
//     }    
// } 
// Console.WriteLine("sum = " + sum);

// PrintMatrix(result);



// alternative: 

// int GetSumDiagonal(int[,] matrix)
// {
//     int sum = 0; // Изначальное значение суммы
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += matrix[i, j]; // sum = sum + matrix[i, j]
//             }
//         }
//     }
//     return sum;
// }
// Console.WriteLine($"Сумма чисел в главной диагонали: {GetSumDiagonal(result)}");


// ================================== DZ ==================================  
// Практическое задание 7. Practice 7. Practice007.


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// double[,] GetMatrix(int m, int n)
// {
//     double[,] matrix = new double[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) - индекс 0 - rows 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // j,m,k 
//         // matrix.GetLength(1) = n, по столбцам
//         {
//             matrix[i, j] = Math.Round(new Random().NextDouble() * 10 , 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(double[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t"); // 
//         }
//         Console.WriteLine(); // пустой врайтлайн, для переноса строчки
//     }
// }

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] result = GetMatrix(rows, columns);
// Console.Clear();
// PrintMatrix(result);
// Console.WriteLine();


// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17->такого числа в массиве нет


// int[,] GetMatrix(int m, int n, int minValue, int maxValue)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) - индекс 0 - rows 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // j,m,k 
//         // matrix.GetLength(1) = n, по столбцам
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i,j] + "\t"); // 
//         }
//         Console.WriteLine(); // пустой врайтлайн, для переноса строчки
//     }
// }

// Console.WriteLine("Введите количество строк матрицы: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов матрицы: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.Clear();
// int [,] result = GetMatrix(rows, columns, 0, 100);
// PrintMatrix(result);
// Console.WriteLine();

// Console.WriteLine("введите номер строки искомого элемента");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца искомого элемента");
// int columns1 = Convert.ToInt32(Console.ReadLine());

// if (rows1 > rows || columns1 > columns) // вроде так быстрее должно быть, чем (rows1 > result.GetLength(0) || columns1 > result.GetLength(1))
// {
//   Console.WriteLine("такого числа в массиве нет");  
// }
// else Console.WriteLine($"значение элемента {rows1} строки и {columns1} столбца равно {result[rows1-1,columns1-1]}");



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) - индекс 0 - rows 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // j,m,k 
        // matrix.GetLength(1) = n, по столбцам
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); // 
        }
        Console.WriteLine(); // пустой врайтлайн, для переноса строчки
    }
}

Console.WriteLine("Введите количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Clear();
int[,] result = GetMatrix(rows, columns, 0, 10);
PrintMatrix(result);
Console.WriteLine();

double average = 0;
// double rez = 0;
Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < result.GetLength(1); j++)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        average += result[i, j]; // average = average + result[i,j];
    }
    average /= columns; // average = average / columns; 

    // rez = Math.Round(average, 2);
    // Console.Write(rez + "; ");
    Console.Write($"{Math.Round(average, 2)}"+ "; ");
}
Console.WriteLine();