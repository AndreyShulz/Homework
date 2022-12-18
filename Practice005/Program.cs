// 18.12.2022 Воскресенье. Двумерные массивы

// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// 2 строчки, 3 столбца, int [rows, columns] 
// [,] кол-во запятых важно, 1 - двумерный масс, две - трёхмерный 
// m - колво строк, n - колво столбцов
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
            Console.Write(inputMatrix[i,j] + "\t"); // 
        }
        Console.WriteLine(); // пустой врайтлайн, для переноса строчки
    }
}
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] result = GetMatrix(rows, columns, 0, 10); // создали матрицу с элементами от 0 до 10

// а теперь неотбходимо её напечатать

PrintMatrix(result);