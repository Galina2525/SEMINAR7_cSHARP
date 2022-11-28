// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
// Amn = m + n. Выведите массив на экран
// m = 3; n = 4
//0123
//1234
//2345
Console.WriteLine("Enter m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n");
int n = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = GetMatrix(m, n, -10, 10);




int [,] GetMatrix(int rowsCount, int columnsCount, int minValue, int maxValue)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    
    for( int i = 0; i < matrix.GetLength(0); i ++)
    {
       for ( int j = 0; j < matrix.GetLength(1); j ++)
       {
        matrix[i,j] = i +j;
       }
    }
    return matrix;
}

PrintMatrix(ourMatrix);

void PrintMatrix(int[,] matrix)
{
      for( int i = 0; i < matrix.GetLength(0); i ++)
    {
       for ( int j = 0; j < matrix.GetLength(1); j ++)
       {
        Console.Write(matrix[i, j] + " ");
       }
       Console.WriteLine();
    } 
}
