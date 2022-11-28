// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
//(с индексами (0,0),(1,1) и т.д.)
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//Сумма элементов главной диагонали 1 + 9 + 2 = 12

Console.WriteLine("Enter m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n");
int n = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = GetMatrix(m, n, -10, 10);

PrintMatrix(ourMatrix);

Console.WriteLine();
int sum = DiagolalEqualIndex(ourMatrix);
Console.WriteLine(sum); 


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

//void DiagolalEqualIndex(int[,] matrix) 
int DiagolalEqualIndex(int[,] matrix) 
{
    int sum =0;
   for( int i = 0; i < matrix.GetLength(0); i ++)
     {
        for ( int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == j)
            {
            
                sum = sum + matrix[i,j];
            }
        }
     }  
     return sum;
}

// int DiagolalEqualIndex(int[,] matrix) 
// {
//     int sum =0;
//      int min;
//    if( matrix.GetLength(0) >  matrix.GetLength(1))
//      {
//         min = matrix.GetLength(1);
//      }
//      else
//      {
//       min = matrix.GetLength(0);
//       }
//       for( int i= 0; i < min; i++ )
//             {
            
//                 sum = sum + matrix[i,i];
//             }
//      return sum;
// }