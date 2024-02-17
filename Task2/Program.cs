int[] myArr =  threeDigNumbers(10, 100, 1000);
int EvenNumbersAmount = EvenNumbers(myArr);
Console.Write(EvenNumbersAmount + "\n");
PrintArray(myArr);



 int[] threeDigNumbers(int size, int LeftBoard, int RightBoard)
{
  
   int[] array = new int[size];
   
   for(int i = 0; i < size; i++){
    array[i] = new Random().Next(LeftBoard, RightBoard + 1);
   }
   return array;
}

int EvenNumbers(int[] array){
int count = 0;
for(int i = 0; i < array.Length; i++){
    if(array[i]%2 == 0)
    count++;
   }
   return count;

}

void PrintArray(int[] array){

   for(int i = 0; i < array.Length; i++){
      Console.Write(array[i] + "\t");
   }
}
