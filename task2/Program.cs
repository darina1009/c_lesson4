int num = ReadLine();
int sum = Sum(num);

Console.WriteLine(sum);

int ReadLine(){
    Console.WriteLine("Введите число");
    string input = Console.ReadLine();
    int num = Convert.ToInt32(input);
    return num;
}

int Sum (int num){
     int sum = 0;
     
    for ( int i = 0; i <  num ; i++){
       
        sum += num % 10; 
        num = num / 10;
    }
    return sum;
}



