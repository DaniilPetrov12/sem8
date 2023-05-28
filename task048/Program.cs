// задайте массив размера m на n в котором элементы находятся по формуле i+j

void FillMatrix(int [,] matrix)
{
    
for (int i =0; i< matrix.GetLength(0);i++)
{
    for ( int j = 0; j < matrix.GetLength(i);j++)
    matrix[i,j] = i +j;
}
}
void PrintMatrix (int [,] matrix)
{

for (int i =0; i< matrix.GetLength(0);i++)
{
    for ( int j = 0; j < matrix.GetLength(i);j++)
    System.Console.WriteLine(($"{matrix [i,j]}"));
} 
}
System.Console.WriteLine("Введите количество строк массива");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [m,n];

FillMatrix(matrix);
PrintMatrix(matrix);