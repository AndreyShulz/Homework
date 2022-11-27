// // Напишите программу которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя)
// Console.WriteLine("vvedite chislo: ");
// int number = Convert.ToInt32(Console.ReadLine()); // tip_dannyh imya = znachenie;
// int result = number * number;
// Console.WriteLine(result);
// Console.WriteLine();

// 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
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

// ========


// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

// int dayNumber = Convert.ToInt32(Console.ReadLine());
// if (dayNumber == 1) Console.WriteLine("Понедельник");


// 5. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("vvedite chislo: ");
// int positiveNumber = Convert.ToInt32(Console.ReadLine()); // N
// if (positiveNumber < 0) positiveNumber*= -1; // из отрицательного числа делает положительное
// int negativeNumber = positiveNumber * (-1);

// while (negativeNumber <= positiveNumber) //пока условие истинно
// {
//     System.Console.Write(negativeNumber + " ");
//     negativeNumber++;

// }
// ==============================================================================================================================

// 2. Напишите программу, которая на вход принимает два числа
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

// 6.Напишите программу, которая на вход принимает число и выдаёт,
//  является ли число чётным (делитлся ли оно на два без остатка).    

// Console.Clear();

// Console.WriteLine("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());

// if (number %2 == 1)

// {
// Console.WriteLine("нечетное число");    
// }
// else Console.WriteLine("четное число");

// 8.Напишите программу, которая на вход приничиет число (N), 
// а на выходе показывает все четные числа от 1 до N 

Console.Clear();

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
while (number > 1)
{
    if (number % 2 == 0)

    {
        Console.WriteLine($"Четное значение из задоного вами набора чисел = {number}");
        number--;
    }
    else
    {
        number--;
    }

}

