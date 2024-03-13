int rows = InputData("Введите количество строк матрицы");
int columns = InputData("Введите количество столбцов матрицы");
int LeftBorder = InputData("Введите левую границу массива");
int RightBorder= InputData("Введите правую границу массива");

int[,]array = GenerateMatrix(rows, columns, LeftBorder, RightBorder);
PrintMatrix(array);
Console.Write("\t");
int[] minNumber = IndexMin(array);
Console.Write($"{minNumber[0]}, {minNumber[1]}");
//Console.Write(array[minNumber[0], minNumber[1]]);
Console.Write("\n");
int[,] newMatrix = EliminateRowAndcolumn(array, minNumber[0], minNumber[1]);
PrintMatrix(newMatrix);
// newMatrixRow(array, minNumber[0]);
// int [,] newMatrixRow = PrintMatrix(newMatrixRow);


int[,] EliminateRowAndcolumn(int[,] array, int x, int y){

    int[,] newArray = new int [array.GetLength(0) - 1, array.GetLength(1) - 1];
    for( int i = 0,  k = 0;  array.GetLength(0) > i, ; i++){
        i => x ? i = i + 1 : i;
        
        {          
           for( int j = 0,  l = 0;  array.GetLength(1) > j, ; j++){
            j => y ? j = j + 1 : j;
       newArray[k, l]  = array[i,j];
                l++;}
        }k++;
    }return newArray;
}

/*код удаления строки */
// int[,]newMatrixRow(int[,]Matrix, int k){

// for (int i  = k; i < Matrix.GetLength(0) - 1; i++) 
//     for (int j = 0; j < Matrix.GetLength(1); j++) 
//         Matrix[i, j] = Matrix[i + 1, j];  
//         return Matrix;}
/*код удаления столбца */
// int[,]newMatrixRowColumn(int[.]Matrix, int l){
// for (int i = 0; i < Matrix.GetLength(0); i++) 
//     for (int j = l; j < Matrix.GetLength(1)- 1; j++) 
//         Matrix[i, j] = Matrix[i, j + 1]; 
//         return Matrix;}


int[,] GenerateMatrix(int rows, int columns, int LeftBorder, int RightBorder)
{
    int[,] myMatrix = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            myMatrix[i, j] = rand.Next(LeftBorder, RightBorder + 1);
        }
    }

    return myMatrix;
}

int InputData(string msg){
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,]array){

    for(int i =0; i < array.GetLength(0); i++){
        for(int j =0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + "\t");
        }Console.WriteLine("");
    }
}

int[] IndexMin(int[,] array){
     int min = array[0, 0];
    int[] indexmin = {0, 0};
    for(int i = 0; i < array.GetLength(0); i++){
        for( int j = 0; j < array.GetLength(1); j++){
            if(array[i,j] < min){
                min = array[i, j];
                indexmin[0] = i;
                indexmin[1] = j;
            }
        }
    }return indexmin;
}
