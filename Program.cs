// задача 1 Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве и возвращает значение этого элемента или же указаниие,
// что такого элемента нет.

// int[,] array2D = {
//             {1, 2, 3},
//             {4, 5, 6},
//             {7, 8, 9}
//         };


// Console.Write("Введите номер строки: ");
// int row = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите номер столбца: ");
// int column = Convert.ToInt32(Console.ReadLine());

// int result = GetArrayElement(array2D, row, column);

// if (result != -1)
// {
//     Console.WriteLine($"Элемент на позиции ({row}, {column}) равен: {result}");
// }
// else
// {
//     Console.WriteLine($"Элемента на позиции ({row}, {column}) не существует.");
// }

// static int GetArrayElement(int[,] array, int row, int column)
// {
//     int rows = array.GetLength(0);
//     int columns = array.GetLength(1);

//     if (row >= 0 && row < rows && column >= 0 && column < columns)
//     {
//         return array[row, column];
//     }
//     else
//     {
//         return -1;
//     }
// }
//---------------------------------------------------------------------

// Задание 2 Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.

// int[,] array2D = {
//             {1, 2, 3},
//             {4, 5, 6},
//             {7, 8, 9}
//         };

// Console.WriteLine("Исходный массив:");
// PrintArray(array2D);

// SwapFirstAndLastRows(array2D);

// Console.WriteLine("\nМассив после обмена:");
// PrintArray(array2D);

//     static void PrintArray(int[,] array)
// {
//     int rows = array.GetLength(0);
//     int columns = array.GetLength(1);

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// static void SwapFirstAndLastRows(int[,] array)
// {
//     int rows = array.GetLength(0);
//     int columns = array.GetLength(1);

//     if (rows >= 2)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             int temp = array[0, j];
//             array[0, j] = array[rows - 1, j];
//             array[rows - 1, j] = temp;
//         }
//     }
//     else
//     {
//         Console.WriteLine("В массиве должно быть хотя бы две строки для обмена.");
//     }
// }

//---------------------------------------------------------------------------

// Задача 3 Задайте двумерный массив. Напиишите программу, которая будет 
// находить строку с наименьшей суммой элементов массива.

// int[,] array2D = {
//             {3, 1, 2},
//             {4, 5, 6},
//             {7, 8, 9},
//             {10, 11, 12}
//         };

// Console.WriteLine("Исходный массив:");
// PrintArray(array2D);

// int minSumRowIndex = FindRowWithMinSum(array2D);

// Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRowIndex + 1}");

//     static void PrintArray(int[,] array)
// {
//     int rows = array.GetLength(0);
//     int columns = array.GetLength(1);

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// static int FindRowWithMinSum(int[,] array)
// {
//     int rows = array.GetLength(0);
//     int columns = array.GetLength(1);

//     int minSum = int.MaxValue;
//     int minSumRowIndex = -1;

//     for (int i = 0; i < rows; i++)
//     {
//         int currentSum = 0;

//         for (int j = 0; j < columns; j++)
//         {
//             currentSum += array[i, j];
//         }

//         if (currentSum < minSum)
//         {
//             minSum = currentSum;
//             minSumRowIndex = i;
//         }
//     }

//     return minSumRowIndex;
// }
