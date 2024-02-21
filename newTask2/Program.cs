
// int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
// {
//     int[,] myMatrix = new int[row, col];
//     Random rand = new Random();

//     for (int i = 0; i < myMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < myMatrix.GetLength(1); j++)
//         {
//             myMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
//         }
//     }

//     return myMatrix;
// }

int[,] numbers = new int[,]{
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12},
    {9, 10, 11, 13},
    {0,0,1,0}

    
};

PrintMatrix(numbers);
SwapFirstLastRows(numbers);
Console.Write("\n");
PrintMatrix(numbers);


void PrintMatrix(int[,]array){

    for(int i =0; i < array.GetLength(0); i++){
        for(int j =0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }Console.WriteLine("");
    }
}


int[,] SwapFirstLastRows(int[,] array){
       int[]temple = new int [4];
      for(int i = 0; i < temple.Length; i++){
           temple[i] = array[0, i];
           array[0, i] = array[array.GetLength(1), i];
           array[array.GetLength(1), i] = temple[i];

      }
      return array;
        
      }
        
        
      
//  int i = 0;
//             // Объявляем ступенчатый массив
//             int[][] myArr = new int[4][];
//             myArr[0] = new int[4];
//             myArr[1] = new int[6];
//             myArr[2] = new int[3];
//             myArr[3] = new int[4];

//             // Инициализируем ступенчатый массив
//             for (; i < 4; i++)
//             {
//                 myArr[0][i] = i;
//                 Console.Write("{0}\t",myArr[0][i]);
//             }

//             Console.WriteLine();
//             for (i = 0; i < 6; i++)
//             {
//                 myArr[1][i] = i;
//                 Console.Write("{0}\t", myArr[1][i]);
//             }

//             Console.WriteLine();
//             for (i = 0; i < 3; i++)
//             {
//                 myArr[2][i] = i;
//                 Console.Write("{0}\t", myArr[2][i]);
//             }

//             Console.WriteLine();
//             for (i = 0; i < 4; i++)
//             {
//                 myArr[3][i] = i;
//                 Console.Write("{0}\t", myArr[3][i]);
//             }

//                 Console.ReadLine();
        
    