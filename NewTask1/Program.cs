using System.Security.Cryptography.X509Certificates;
int rows = InputData("Введите количество строк матрицы");
int columns = InputData("Введите количество столбцов матрицы");
int x = InputData("Введите строку искомого числа");
int y = InputData("Введите столбец искомого числа");


int[,]array = GenerateMatrix(rows, columns, 7, 89);
PrintMatrix(array);
if(ValidatePosition(array, x, y)){
    //FindElement(array, x, y);
    PrintResult(array, x, y);
}


Console.Write("\n");





void PrintMatrix(int[,]array){

    for(int i =0; i < array.GetLength(0); i++){
        for(int j =0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }Console.WriteLine("");
    }
}




bool ValidatePosition( int[,] array,  int x,  int y)
{
    
if((x > array.GetLength(0) - 1) && (y > array.GetLength(1) - 1)){
    Console.Write(" Строчек не хватило и столбцов тоже маловато");
     return false;
    }
     if (y > array.GetLength(1) - 1){
        Console.Write("столбцов не хватило");
       return false;
    }
    if(x > array.GetLength(0) - 1){

        Console.Write("Строчек не хватает только...");
        return false;
    }
    else{
        return true;
    }
}
    
    




void PrintResult(int[,]array, int x, int y){
 Console.Write(FindElement(array, x, y));
}


int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] myMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            myMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return myMatrix;
}
int FindElement(int[,]array, int x, int y){
   
  return array[x, y];

} 

int InputData(string msg){
  Console.Write(msg);
  return Convert.ToInt32(Console.ReadLine());

}

    




   
