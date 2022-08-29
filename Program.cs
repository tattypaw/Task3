/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

void Palindrom(int n){
    string num = Convert.ToString(n);
    if (num[0] == num[4] & num[1] == num[3]) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 99999 & num >= 10000) Palindrom(num);
else Console.WriteLine("Некорректный ввод");
*/

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

int fInput(string s)
{
    Console.Write("Введите координату " + s);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

void fLen(int a, int b, int c, int x, int y, int z)
{
    double result = Math.Sqrt((a - x) * (a - x) + (b - y) * (b - y) + (c - z) * (c - z));
    Console.WriteLine(result);
}

Console.WriteLine("Введите координаты первой точки");
int x1 = fInput("x1 = ");
int y1 = fInput("y1 = ");
int z1 = fInput("z1 = ");

Console.WriteLine("Введите координаты второй точки");
int x2 = fInput("x2 = ");
int y2 = fInput("y2 = ");
int z2 = fInput("z2 = ");

Console.Write("Расстояние между точками = ");
fLen(x1, y1, z1, x2, y2, z2);
*/

/*
Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
void Cube(int n){
    int curr = 1;
    while(curr<=n){
        Console.Write(curr*curr*curr + ", ");
        curr++;
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0) Console.Write("Некорректный ввод");
else Cube(num);