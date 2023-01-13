//==============================13.01.2023==============================

//==============================Задача_1==============================

// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число А в натуральную степень В.
// Пример: 3, 5 -> 243 (3 в степени 5)
//         2, 4 -> 16

/*
Console.Clear();

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int constant = A;

for (int i = 0; i < B - 1; i++)
{
    A *= constant;
}

Console.Write(A);
*/

//==============================Задача_2==============================

// Напишите программу, которая принимает 
// на вход число и выдает сумму цифр в числе.
// Пример: 452 -> 11
//         82 -> 10
//         9012 -> 12

/*
Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 10;

while (number / 10 != 0)
{
    number /= 10;
    result += number % 10;
}

Console.WriteLine(result);
*/

//==============================Задача_3==============================

// Напишите программу, которая задает массив
// из 8 элементов и выводит их на экран.
// Пример: 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//         6, 1, 33 -> [6, 1, 33]

/*
Console.Clear();

Console.Write("Введите размер массива: ");
int index = Convert.ToInt32(Console.ReadLine());

int[] array = new int[index];
Random rand = new Random();

Console.WriteLine();

for (int i = 0; i < index; i++)
{
    array[i] = rand.Next(1, 11);
    Console.Write($"{array[i]} ");
}
*/