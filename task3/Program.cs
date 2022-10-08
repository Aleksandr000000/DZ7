// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int GetNumberFromConsole(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 100);
        }
    }
}

void PrintArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}

void AverageColumn(int[,] array, int n)

{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avarage = avarage + array[i, j];
        }
        avarage = avarage / n;
        Console.Write(Math.Round(avarage, 2) + "; ");

    }

}



int m = GetNumberFromConsole("Введите размерность массива. Количество строк: ");
int n = GetNumberFromConsole("Введите размерность массива. Количество столбцов: ");
int[,] arr = new int[m, n];
FillArrayRandomNumbers(arr); /// заполняем массив определенного размера
PrintArrayRandomNumbers(arr); /// выводим на экран  массив случайных чисел
Console.Write("Среднее арифметическое каждого столбца: ");
AverageColumn(arr, n); // подсчитываем среднне арифметическое и выводим на экран
