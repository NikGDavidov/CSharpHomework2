//  Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
// этого числа
int deleteSecondDigit(int x){
int x1 = x/100;
int x2 = x%10;
return  x1*10+x2;
}

int number = new Random().Next(100,999);
Console.WriteLine(number);
number = deleteSecondDigit(number);
Console.WriteLine(number);