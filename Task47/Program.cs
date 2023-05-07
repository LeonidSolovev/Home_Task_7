// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int[,] array = NewArray(GetUserInput("Укажите размер массива по горизонтали: ", "Ошибка ввода!"), GetUserInput("Укажите размер массива по вертикали: ", "Ошибка ввода!"), GetUserInput("Укажите минимальное значение: ",
 "Ошибка ввода!"), GetUserInput("Укажите максимальное значение: ", "Ошибка ввода!"));


Console.WriteLine($"m = {array.GetLength(0)}, n = {array.GetLength(1)}");

PrintArray(array);

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