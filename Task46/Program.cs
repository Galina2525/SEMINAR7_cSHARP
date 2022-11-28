// Задайте двумерный массив размером m x n, заполненный случайными целыми числами
//m =3, n =4
//1 4 8 1
//5 -2 33 -2
//77 3 8 1

Console.WriteLine("Enter m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n");
int n = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = GetMatrix(m, n, -10, 10);

//Console.WriteLine(string.Join(" ,  ", ourMatrix));//этот метод не работает


int [,] GetMatrix(int rowsCount, int columnsCount, int minValue, int maxValue)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random random = new Random();
    for( int i = 0; i < matrix.GetLength(0); i ++)
    {
       for ( int j = 0; j < matrix.GetLength(1); j ++)
       {
        matrix[i,j] = random.Next(minValue, maxValue);
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
