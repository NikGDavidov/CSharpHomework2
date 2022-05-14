
int secondDigit(int a){
    int result = a/10;
    result = result%10;
    return result;
}
int x = 0;
while (true){
 Console.WriteLine("Введите трехзначное число: ");
 x= int.Parse(Console.ReadLine());
    if (x > 999 || x < 100) Console.WriteLine ("Введенное число не является трехзначным.");
    else break;
}
 Console.WriteLine(secondDigit(x));