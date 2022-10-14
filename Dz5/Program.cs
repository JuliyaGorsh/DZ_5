// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void FillArr(int[]array)
{
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(100,1000);
        index++;
    }
}
void PrintArr(int[] array)
{
    int count = array.Length;
    int i = 0;
    while (i < count)
    {
        Console.Write($"{array[i]} ");
        i++;
    }
}
void Even(int[]Array)
{
    int i = 0;
    int sum = 0;
    while (i < Array.Length)
    {
    if(Array[i]%2 == 0)
    {
sum++;
    }
    i++;
    }
    Console.WriteLine($"Кол-во четных чисел: {sum}");
}

int[]Arr = new int [6];
FillArr(Arr);
PrintArr(Arr);
Console.WriteLine();
Even(Arr);


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void FillArr(int[]array)
// {
//     int index = 0;
//     while (index < array.Length)
//     {
//         array[index] = new Random().Next(-100,101);
//         index++;
//     }
// }
// void PrintArr(int[] array)
// {
//     int count = array.Length;
//     int i = 0;
//     while (i < count)
//     {
//         Console.Write($"{array[i]} ");
//         i++;
//     }
// }
// void Sum(int[]array)
// {
//     int i = 0;
//     int sum = 0;
// while(i < array.Length)
// {
//     if (i%2 == 1)
//     {
//         sum = sum + array[i];
//     }
//     i++;
// }
// Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");
// }

// int[]Arr = new int [4];
// FillArr(Arr);
// PrintArr(Arr);
// Console.WriteLine();
// Sum(Arr);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// void FillArr(int[]array)
// {
//     int index = 0;
//     while (index < array.Length)
//     {
//         array[index] = new Random().Next(0,100);
//         index++;
//     }
// }
// void PrintArr(int[] array)
// {
//     int count = array.Length;
//     int i = 0;
//     while (i < count)
//     {
//         Console.Write($"{array[i]} ");
//         i++;
//     }
// }
// void Sum(int[]array) 
// {
//     int i = 0;
//     int index = 0;
//     int Max = array[0];
//     int Min = array[0];
// while (i < array.Length)
// {
//     if(array[i] > Max) 
//     {
//     Max = array[i];
//     }
// i++;
// }
// while (index < array.Length)
// {
//     if(array[index] < Min) 
//     {
//     Min = array[index];
//     }
// index++;
// }
// Console.WriteLine($"Максимальное число в массиве: {Max}, минимальное: {Min}");
// Console.WriteLine($"Разность чисел: {Max-Min}");
// }

// int[]Arr = new int [10];
// FillArr(Arr);
// PrintArr(Arr);
// Console.WriteLine();
// Sum(Arr);