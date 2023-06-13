
int num = ReadLine();
int stepen = Convert.ToInt32(Console.ReadLine());
int pow = Power(num, stepen);
Console.WriteLine($"Степень {pow}");


int ReadLine(){
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень");
  
    return num;
}

int Power(double num, double stepen){
     int pow = Convert.ToInt32(Math.Pow(num,stepen ));

    return pow;
}