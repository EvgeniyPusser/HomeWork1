 
 int[,] numbers = new int[,]{
    {1, 2, 110},
    {1, 122, 10},
    {7, 8, 2},
    {9, 10, 11}
   };
 int[] sums = SumRows(numbers);
 int IndexMin = MinIndex(sums);
 //Console.Write(IndexMin);
 PrintResult(numbers);
 Console.Write("\n");
 
 
 
  int[] SumRows(int[,] array)
    {
      int [] sumArray = new int[array.GetLength(0)];
      //int rowSum = 0;
      for(int i = 0; i < array.GetLength(0); i++){
        for(int j =0; j < array.GetLength(1); j++){
            sumArray[i] += array[i,j];
        }
      }return sumArray;
      
    }
    
    
     int MinIndex(int[] array)
    {
       int IndexMin = 0;
       //int min = array[0];
       for(int i =0; i < array.Length; i++){
        if(array[i] < array[IndexMin]){
            //min = array[i];
          IndexMin = i;
        }}return IndexMin;
     }
    void PrintResult(int[,] array)
    {   
      Console.Write(IndexMin);
    }
      
