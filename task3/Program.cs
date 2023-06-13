using System;

RandomArray();

int [] RandomArray(){
int [] array = new int[8];
for (int a = 0; a < array.Length; a++){
    array[a] = new Random().Next(100);
    Console.WriteLine(array[a]);
}
return array;
}