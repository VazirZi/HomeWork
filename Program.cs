//============================== 13.01.2023 ==============================

//============================== Задача_1 ==============================

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

//============================== Задача_2 ==============================

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

//============================== Задача_3 ==============================

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



//============================== 16.01.2023 ==============================



//============================== Задача_1 ==============================

// Задайте массив, заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.

// Пример: [345, 897, 568, 234] -> 2

/*
Console.Clear();

int NumberEnter (string str)
{
    Console.Write(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] InitializArray (int size)
{
    int[] array = new int[size];
    return array;
}

void FullArray (int[] array)
{   
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(11);
    }
}

void PrintArray (int[] array)
{
    Console.WriteLine("\nИсходный массив:");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    } 
}

int CountOfEvenNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0 && array[i] != 0)
        {
            count++;
        }
    }

    Console.WriteLine($"\n\nКоличество четных чисел в массиве = {count}.\n");
    return count;
} 

int n = NumberEnter("Введите размер массива: ");
int[] array = InitializArray(n);
FullArray(array);
PrintArray(array);
int result = CountOfEvenNumbers(array);
*/

//============================== Задача_2 ==============================

// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.

// Пример: [3, 7, 23, 12] -> 19
//         [-4, -6, 89, 6] -> 0

/*
Console.Clear();

int NumberEnter (string str)
{
    Console.Write(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] InitializArray (int size)
{
    int[] array = new int[size];
    return array;
}

void FullArray (int[] array)
{   
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-10, 11);
    }
}

void PrintArray (int[] array)
{
    Console.WriteLine("\nИсходный массив:");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    } 
}

int SumOfNembersOnOddPositionIndex (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }

    Console.WriteLine($"\n\nСумма элементов, стоящих на нечетных позициях = {sum}.\n");
    return sum;
}

int n = NumberEnter("Введите размер массива: ");
int[] array = InitializArray(n);
FullArray(array);
PrintArray(array);
int result = SumOfNembersOnOddPositionIndex(array);
*/

//============================== Задача_2 ==============================

// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементами массива.

// Пример: [3 7 22 2 78] -> 76

/*
Console.Clear();

int NumberEnter (string str)
{
    Console.Write(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] InitializArray (int size)
{
    int[] array = new int[size];
    return array;
}

void FullArray (int[] array)
{   
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1, 100);
    }
}

void PrintArray (int[] array)
{
    Console.WriteLine("\nИсходный массив:");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    } 
}

int MaxItemOfArray (int[] array)
{
    int max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }   

    return max;
}

int MinItemOfArray (int[] array)
{
    int min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }

    return min;
}

int n = NumberEnter("Введите размер массива: ");
int[] array = InitializArray(n);
FullArray(array);
PrintArray(array);

int result = (MaxItemOfArray(array) - MinItemOfArray(array));

Console.Write($"\n\nРазница между максимальным и минимальным элементами массива = {result}");
*/