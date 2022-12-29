// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// ***************Задача 1******************
//  Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Console.WriteLine("Введите количество строк");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int col = Convert.ToInt32(Console.ReadLine());

// int [,] Getarray()
// {
//     int[,] matrix = new int [row,col];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(10);
//         }
//     }
//     return matrix;
// }

// int[,] Changerows(int [,] matrix)
// {
//     int temp = 0;
//     int rowscount=matrix.GetLength(0)-1;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         temp = matrix[0,i];
//         matrix[0,i] = matrix[rowscount,i];
//         matrix[rowscount,i]=temp;
//     }
//     return matrix;
// }

// void Printarray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j]+":");
//         }
//         Console.WriteLine();
//     }
    
// }
// int[,] array=Getarray();
// Printarray(array);
// Console.WriteLine();
// Changerows(array);
// Printarray(array);

// ********************Конец**************************
// ********************Задача 2***********************
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, 
// если это невозможно, программа должна вывести сообщение для пользователя.

// Console.WriteLine("Введите количество строк");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int col = Convert.ToInt32(Console.ReadLine());

// if (row!=col)
// {
//     Console.WriteLine("Массив не подходит");
// }
// else
// {
//     int [,] array = Getarray();
//     Printarray(array);
//     Console.WriteLine();
//     Printarray(Changearray(array));
// }

// int [,] Getarray()
// {
//     int[,] matrix = new int [row,col];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(10);
//         }
//     }
//     return matrix;
// }

// int [,] Changearray(int [,] matrix)
// {
//     int [,] matrix2 = new int [matrix.GetLength(0),matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix2[j,i]=matrix[i,j];
//         }
//     }
//     return matrix2;
// }

// void Printarray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j]+":");
//         }
//         Console.WriteLine();
//     }
// }

// ***************Конец****************************
// ***************Задача 3************************

// Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7


// Console.WriteLine("Введите количество строк");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int col = Convert.ToInt32(Console.ReadLine());

// int minwalue =int.MaxValue;
// int minindexrow = 0;
// int minindexcol = 0;
// int [,] array = Getarray();
// Printarray(array);
// Console.WriteLine();
// Changearray(array);


// int [,] Getarray()
// {
//     int[,] matrix = new int [row,col];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(10);
//             if (matrix[i,j]<minwalue)
//             {
//                 minwalue=matrix[i,j];
//                 minindexrow = i;
//                 minindexcol = j;
//             }
//         }
//     }
//     return matrix;
// }

// void Changearray(int [,] matrix)
// {
//     int [,] matrix2 = new int [matrix.GetLength(0),matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         if (i!=minindexrow)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (j!=minindexcol)
//                 {
//                     matrix2[i,j]= matrix[i,j];
//                     Console.Write(matrix2[i,j]+":");
//                 }
//             }
//             Console.WriteLine();
//         }
        
//     }
    
// }
// void Printarray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j]+":");
//         }
//         Console.WriteLine();
//     }
// }

// ****************Конец**********************************8
