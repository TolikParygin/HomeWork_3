Console.Clear();
double FindDistans(int x1, int y2, int z1, int x2, int y1, int z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}

int DataEnteryXYZ(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int x1 = DataEnteryXYZ("Введите x1: ");
int y1 = DataEnteryXYZ("Введите y1: ");
int z1 = DataEnteryXYZ("Введите z1: ");
int x2 = DataEnteryXYZ("Введите x2: ");
int y2 = DataEnteryXYZ("Введите y2: ");
int z2 = DataEnteryXYZ("Введите z2: ");
double result = FindDistans(x1, y1, z1, x2, y2, z2);
Console.WriteLine("Длина отрезка: " + result);
