// See https://aka.ms/new-console-template for more information

// Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры
// нет.

int numberOfDigits(int a){
    int i = 0;
    while (a>0){
        a = a/10;
        i++;
    }return i;
}
Console.WriteLine("Введите любое целое число");
 int x= int.Parse(Console.ReadLine());
 if (x<0) x=-x;
 int i = numberOfDigits(x);
 if (i>2){
     int delitel = (int) Math.Pow (10, i-3);
     int result = x/delitel;
     result = result%10;
     Console.WriteLine(result);
 }else Console.WriteLine("Третьей цифры нет.");