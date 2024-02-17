int[] arrayFor = GeneriseArray(9, 1, 11);
PrintArray(arrayFor);
Console.Write("\n");
arrayOver(arrayFor);
PrintArray(arrayFor);
Console.Write("\n");


void PrintArray(int []array){

    for(int i =0; i < array.Length; i++){

        Console.Write(array[i] + "\t");
    }
}



int[] GeneriseArray(int size, int LBorder, int RBorder){
    int[] array = new int [size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(LBorder, RBorder);
    }

   return array;

}


void arrayOver(int[]array){
        int my_buffer = 0;
    for(int i = 0; i < array.Length / 2; i++){
       my_buffer = array[i];
       array[i] = array[array.Length - 1 - i];
       array[array.Length-1-i] = my_buffer;

    } 
        
}
