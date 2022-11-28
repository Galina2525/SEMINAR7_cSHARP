// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти 
//элементы на их квадраты
Console.WriteLine("Enter m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n");
int n = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = GetMatrix(m, n, -10, 10);

PrintMatrix(ourMatrix);

SqrEvenIndex(ourMatrix);
Console.WriteLine();
PrintMatrix(ourMatrix);




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

// int[,] ourMatrix2 = new int [m,n];

//     for( int i = 0; i < ourMatrix2.GetLength(0); i ++)
//     {
//        for ( int j = 0; j < ourMatrix2.GetLength(1); j ++)
//        {
//         if(i %2 ==0 & j % 2 ==0)
//         {
//         ourMatrix2[i,j] = ourMatrix[i,j] * ourMatrix[i,j];
//        }
//        else
//        {
//          ourMatrix2[i,j] = ourMatrix[i,j];
//        }
//        }
//    }





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

void SqrEvenIndex(int[,] matrix) // меняем матрицу по ссылке, т.к. работаем с одной матрицей
{
   for( int i = 0; i < matrix.GetLength(0); i = i+2)
     {
        for ( int j = 0; j < matrix.GetLength(1); j =j +2)
        {
            matrix[i,j] = matrix[i,j] * matrix[i,j];
        }
     }  
      
}
