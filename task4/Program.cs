// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 

int number =0;
while (true){
    Console.WriteLine("Введите номер дня недели");
    number = int.Parse(Console.ReadLine());
    if (number>0 && number<8) break;
}
if (number<=5) Console.WriteLine("Нет,это не выходной");
else Console.WriteLine("Да,этo выходной день");