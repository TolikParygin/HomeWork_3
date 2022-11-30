// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int temporaryNumber = number;// Временная переменная для цикла
int count = 0;
int palindrom = 0;
while (count < 5)
{
    palindrom = palindrom * 10 + (temporaryNumber % 10);
    temporaryNumber = temporaryNumber / 10;
    count++;
}
if (number == palindrom) Console.Write($"{number} -> да");
else Console.Write($"{number} -> нет");
