
int[] GetArray(int size, int minValue, int maxValue) 
// size - размер массива, minValue - минимальное число (-9), maxValue - максимальное число (9)
{
// int size = 12; // размер исходного массива по условию
int [] array = new int [size]; // получился массив из 12 нулей : [0,0,0,0,0,0,0,0...]
// for (int i = 0; i < array.Length; i++)
for (int i = 0; i < size; i++) // сэкономили время работы программы, array.Lenght - дольше считается,чем объявленная переменная size
{
    array[i] = new Random().Next(minValue, maxValue + 1); // чтобы 9 тоже бралось сделали +1, если бы не сделали максимальное было бы 8
}
return array;
}
// Вызов функцииas asd