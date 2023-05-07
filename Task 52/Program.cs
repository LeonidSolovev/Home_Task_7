// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = NewArray(GetUserInput("Укажите размер массива по горизонтали: ", "Ошибка ввода!"), GetUserInput("Укажите размер массива по вертикали: ", "Ошибка ввода!"), GetUserInput("Укажите минимальное значение: ",
 "Ошибка ввода!"), GetUserInput("Укажите максимальное значение: ", "Ошибка ввода!"));

PrintArray(array);

double [] averages = GetAvgForRows(array);

PrintDoubleArray(averages);

static int GetUserInput(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        Console.WriteLine(errorMessage);
    }

}

static int[,] NewArray(int size1, int size2, int from, int to)
{
    int[,] arr = new int[size1, size2];
    Random rnd = new Random();
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
            arr[i, j] = new Random().Next(from, to + 1);
    }
    return arr;
}

double [] GetAvgForRows(int [,] arr){
    double [] avgs = new double [arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            avgs[i] += arr[i,j];
                   }
    }
    for (int k = 0; k < arr.GetLength(0); k++)
    {
        avgs[k] = avgs[k]/arr.GetLength(1);
    }    
    return avgs;
}

static void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
    Console.WriteLine();        
    }

}

 void PrintDoubleArray(double [] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
                Console.Write($"{arr[i]} ");
    }
}