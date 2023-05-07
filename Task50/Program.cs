// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] array = NewArray(GetUserInput("Укажите размер массива по горизонтали: ", "Ошибка ввода!"), GetUserInput("Укажите размер массива по вертикали: ", "Ошибка ввода!"), GetUserInput("Укажите минимальное значение: ",
 "Ошибка ввода!"), GetUserInput("Укажите максимальное значение: ", "Ошибка ввода!"));

PrintArray(array);

NumberSearch(GetUserInput("Введите число: ", "Ошибка ввода!"), array);

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

void NumberSearch(int num, int[,] arr)
{
    int count =0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (num == arr[i, j])
            {
                Console.WriteLine($" {num} -> находится на строке {i}, позиция {j}");
                count++;
            }

        }
    }
    if (count == 0) Console.Write("Такого числа нет в массиве");
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