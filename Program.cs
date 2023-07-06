/*



Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

Задача 54:
__________
Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
________________________________________________________________________________
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}
void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}
void DescendingOrder(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

    
int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");
int[,] myArray = Create2DArray(rows, cols);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
DescendingOrder(myArray);
[,] resultArray = DescendingOrder(myArray);
Print2DArray(resultArray);

Задача 56:
__________
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку
с наименьшей суммой элементов.
_________________________________________________________

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

void MinSum(int[,] array)
{
    int sum = 0;
    int res = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        sum += array[i, j];
        sum += sum;
        res = index[i,j];
    }
    return res;
}
    
int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");
int[,] myArray = Create2DArray(rows, cols);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
DescendingOrder(myArray);
[,] resultArray = MinSum(myArray);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {res} строка");

Задача 58: 
__________
Задайте две матрицы. Напишите программу, которая 
будет находить произведение двух матриц.
__________________________________________________________
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

c11 = a11·b11 + a12·b21 = 2·3 + 4·3 = 18

c12 = a11·b12 + a12·b22 

c21 = a21·b11 + a22·b21 

c22 = a21·b12 + a22·b22 



Для того, чтобы найти произведение матриц
нужно строки левой матрицы умножить на столбцы правой матрицы.
Матрицы A и B могут быть перемножены, если они совместимы в том смысле,
что число столбцов матрицы A равно числу строк B. 
Пример решения: 
С = A · B =  
4	2
9	0 * 
3	1
-3	4
  =  
6	12
27	9
 
Элементы матрицы C вычисляются следующим образом:

c11 = a11·b11 + a12·b21 = 4·3 + 2·(-3) = 12 - 6 = 6

c12 = a11·b12 + a12·b22 = 4·1 + 2·4 = 4 + 8 = 12

c21 = a21·b11 + a22·b21 = 9·3 + 0·(-3) = 27 + 0 = 27

c22 = a21·b12 + a22·b22 = 9·1 + 0·4 = 9 + 0 = 9

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void CompositionMatrix(int[,] matrix1, int[,] matrix2)
{
    int aRows = matrix1.Length[0]; 
    int aCols = matrix1[1].Length;
    int bRows = matrix2.Length[0]; 
    int bCols = matrix2[1].Length;
    if (aCols != bRows) Console.WriteLine("Невозможно вычислить произведение матриц.");   
    double[][] result = MatrixCreate(aRows, bCols);
    for (int i = 0; i < aRows; i++) 
        for (int j = 0; j < bCols; j++) 
        for (int k = 0; k < aCols; k++)
        result[i][j] += matrix1[i][k] * matrix2[k][j];
    return result;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

int[,] myArray = Create2DArray(rows, cols);
int[,] myNextArray = Create2DArray(rows, cols);
FillArray(myArray, minValue, maxValue);
FillArray(myNextArray, minValue, maxValue);
PrintArray(myArray);
PrintArray(myNextArray);
Console.WriteLine();
CompositionMatrix(myArray);
Print2DArray(myArray);


Задача 60
__________
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
_________________________________________________________________________
Массив размером 2 x 2 x 2
 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[,,] Create3DArray(int rows, int columns, int depth)
{
    return new int[rows, columns, depth];
}

void Fill3DArray(int[,,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1); k++)
                array[i, j, k] = rnd.Next(min, max + 1);
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1); k++)
                {
                Console.WriteLine($"{array[i, j, k]}({i},{j},{k})\t"); //66(0,0,0)
                }
    }
}

int height = InputNum("Введите количество строк по оси X: ");
int width = InputNum("Введите количество строк по оси Y: ");
int thickness = InputNum("Введите количество строк по оси Z: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

int[,,] my3DArray = Create3DArray(height, width, thickness);
Fill3DArray(my3DArray, minValue, maxValue);
Print3DArray(my3DArray);





