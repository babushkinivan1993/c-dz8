// Task1 Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// void Show2dArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j]>0 && array[i,j]<10) Console.Write(array[i,j] + "   ");
//             if (array[i,j]>9 && array[i,j]<100) Console.Write(array[i,j] + "  ");
//             if (array[i,j]>99) Console.Write(array[i,j] + " "); 
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("___________________________________");
// }
// int[,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int [rows,columns];
//     for (int i = 0; i<rows; i++)
//         for (int j=0;j<columns;j++)
//             array[i,j] = new Random().Next(minValue,maxValue+1);
//     return array;
// }
// void SortInRow (int[,] array)
// {
//     for (int i = 0; i<array.GetLength(0); i++)
//     {
//         for (int j = 0; j<array.GetLength(1)-1; j++)
//         {
//             if (array[i,j+1] > array[i,j])
//             {
//                 int max = array[i,j+1];
//                 array[i,j+1] = array[i,j];
//                 array[i,j] = max;
//                 j=-1;
//             } 
//         }
//     }
// }
// int[,] myArray = CreateRandom2dArray(5,8,1,999);
// Console.WriteLine("Random massiv:");
// Show2dArray(myArray);
// SortInRow(myArray);
// Console.WriteLine("Sorted massiv:");
// Show2dArray(myArray);

// Task2 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// void Show2dArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j]>0 && array[i,j]<10) Console.Write(array[i,j] + "   ");
//             if (array[i,j]>9 && array[i,j]<100) Console.Write(array[i,j] + "  ");
//             if (array[i,j]>99) Console.Write(array[i,j] + " "); 
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("___________________________________");
// }
// int[,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int [rows,columns];
//     for (int i = 0; i<rows; i++)
//         for (int j=0;j<columns;j++)
//             array[i,j] = new Random().Next(minValue,maxValue+1);
//     return array;
// }
// void MinimumRowsSumm (int[,] array)
// {
//     int numberOfRow = 0;
//     int min = 2147483647;
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j=0; j<array.GetLength(1); j++) sum = sum + array[i,j];
//         if (sum<min) 
//         {
//             min = sum;
//             numberOfRow = i;
//         }
//     }
// Console.WriteLine($"Number of row whith the minimum summ - {numberOfRow}");
// }
// int[,] myArray = CreateRandom2dArray(5,8,1,999);
// Show2dArray(myArray);
// MinimumRowsSumm(myArray);

// Task3 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// void Show2dArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j]==0) Console.Write(array[i,j] + "   ");
//             if (array[i,j]>0 && array[i,j]<10) Console.Write(array[i,j] + "   ");
//             if (array[i,j]>9 && array[i,j]<100) Console.Write(array[i,j] + "  ");
//             if (array[i,j]>99) Console.Write(array[i,j] + " "); 
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("___________________________________");
// }
// int[,] MatrixMultiplication (int[,] array1, int[,] array2)
// {
// int[,] multiplicationArray = new int [array1.GetLength(0), array2.GetLength(1)];
//         for (int i=0; i<array1.GetLength(0); i++)
//             for (int j=0; j<array2.GetLength(1); j++) multiplicationArray[i,j] = array1[i,0]*array2[0,j] + array1[i,array1.GetLength(1)-1]*array2[array1.GetLength(1)-1,j];
//     return multiplicationArray;
// }
// int [,] array1 = new int [2,2] {{3,4} , {2,1}};
// int [,] array2 = new int [2,2] {{0,5} , {9,3}};
// Console.WriteLine("Matrix 1:");
// Show2dArray(array1);
// Console.WriteLine("Matrix 2:");
// Show2dArray(array2);
// if (array1.GetLength(1) == array2.GetLength(0))
// {
// int[,] newArray = MatrixMultiplication(array1,array2);
// Console.WriteLine("The multiplication matrix's:");
// Show2dArray(newArray);
// }
// else Console.WriteLine("Matrix's cannot be multiplied");

// Task4 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// int[,,] CreateRandom3dArray (int x, int y, int z)
// {
//     int[,,] array = new int [x,y,z];
//     int number = 10;
//     for (int i = 0; i<x; i++)
//         for (int j=0;j<y;j++)
//             for (int k=0; k<z;k++)
//             {
//             array[i,j,k] = number;
//             number = number+1;
//             }
//     return array;
// }
// void Show3dArray (int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k=0; k < array.GetLength(2); k++)
//             {
//                 if (array[i,j,k]>0 && array[i,j,k]<10) Console.Write(array[i,j,k] + i + j + k + "   ");
//                 if (array[i,j,k]>9 && array[i,j,k]<100) Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
//                 if (array[i,j,k]>99) Console.Write(array[i,j,k] + i + j + k + " "); 
//             }
//         Console.WriteLine();
//         }
    
//     Console.WriteLine("___________________________________");
//     }
// }
// int[,,] myArray = CreateRandom3dArray(2,2,2);
// Show3dArray(myArray);

// Task5 Напишите программу, которая заполнит спирально массив.
// void Show2dArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j]==0) Console.Write(array[i,j] + "   ");
//             if (array[i,j]>0 && array[i,j]<10) Console.Write(array[i,j] + "   ");
//             if (array[i,j]>9 && array[i,j]<100) Console.Write(array[i,j] + "  ");
//             if (array[i,j]>99) Console.Write(array[i,j] + " "); 
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("___________________________________");
// }
// int[,] SpiralComplition (int m, int n)
// {
//     int circle = 0;
//     int min = 0;
//     if (m<=n) min = m;
//     else min = n;
//     if (min%2==0) circle = min/2;
//     else circle = min/2+1;
//     int number = 1;
//     int[,] array = new int [m,n];
// for (int x=0;x<circle;x++)
// {
//         for (int j=0+x; j<n-x; j++)
//         {
//             int i=0+x;
//             array[i,j] = number;
//             number = number+1;
//         }
//         if ((x+1)*2<min)
//         {
//         for (int i=1+x; i<m-x; i++)
//         {
//             array[i,n-1-x] = number;
//             number = number+1;
//         }
//         for (int j=n-2-x; j>=0+x;j--)
//         {
//             array[m-1-x, j] = number;
//             number = number+1;
//         }
//         for (int i=m-2-x; i>0+x;i--)
//         {
//             array[i,0+x] = number;
//             number = number+1;
//         }
//         }
// }
//     return array;
// }
// int[,] myArray = SpiralComplition(7,11);
// Show2dArray(myArray);
