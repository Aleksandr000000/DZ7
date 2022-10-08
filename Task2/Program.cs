// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int GetNumberFromConsole(string text) /// задаем размерность массива
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array) /// создаем массив определенного зазмера
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(100, 1000);
        }
    }
}

void PrintArrayRandomNumbers(int[,] array) /// заполняем массив случайными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

int GetNumberFromConsolePosition(string text) /// Вводим позиции определенного элемента
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void ElementValuePosition(int[,] array, int m, int n, int column, int line) /// достаем нужное нам число по введенным параметрам
{
    if ((column > 0 & column <= m) & (line > 0 & line <= n))
    {
        Console.WriteLine(array[column - 1, line - 1]);
    }
    else
        Console.WriteLine($"По введенной позиции  [{column},{line}], нет никакого числа ");

}



int m = GetNumberFromConsole("Введите размерность массива. Количество строк: ");
int n = GetNumberFromConsole("Введите размерность массива. Количество столбцов:  ");
int[,] arr = new int[m, n];
FillArrayRandomNumbers(arr);
PrintArrayRandomNumbers(arr);
int column = GetNumberFromConsolePosition("Введите адресс позиции. строка: ");
int line = GetNumberFromConsolePosition("Введите адресс позиции. столбец: ");
ElementValuePosition(arr, m, n, column, line);

