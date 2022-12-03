// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125
Console.Clear();
void FindCube(int N)
{
    int count = 1;
    Console.Write(N + " -> ");
    while (count <= N)
    {
        Console.Write(Math.Pow(count, 3) + "  ");
        count++;
    }
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
FindCube(number);