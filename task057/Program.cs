// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// void FillMatrixWhithRandomNumbers(int[,] matrix)
// {
// Random rnd = new Random();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i, j] = rnd.Next(0, 11);
// }
// }
// }

// void PrintMatrix(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// System.Console.Write($"{matrix[i, j]} " + "\t");
// }
// System.Console.WriteLine();
// }
// }

// System.Console.Write("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[m, n];


// FillMatrixWhithRandomNumbers(matrix);
// PrintMatrix(matrix);



void FillMatrixWhithRandomNumbers(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} " + "\t");
        }
        System.Console.WriteLine();
    }
}

void CountElement(int[,] matrix)
{

    for (int count = 0; count < 10; count++)
    {
        int n = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == count)
                    n++;
            }
        }
        if(n != 0)
        System.Console.WriteLine($"{count} встречается {n} раз(а)");
    }
}
    System.Console.Write("Введите количество строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[m, n];

    FillMatrixWhithRandomNumbers(matrix);
    PrintMatrix(matrix);
    System.Console.WriteLine();
    CountElement(matrix);