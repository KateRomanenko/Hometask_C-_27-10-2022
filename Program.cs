// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/* Console.WriteLine("Введите пятизначное число: ");
string str = Console.ReadLine();
char[] pal = str.ToCharArray();

if(str.ToCharArray().Length==5)
{
    Console.WriteLine("число введено верно");
}
else
{
    Console.WriteLine("число непятизначное");
}
{
if(pal[0] == pal[4] && pal[1] == pal[3])
{
    Console.WriteLine("палиндром");
}
else
{
    Console.WriteLine("не палиндром");
}

} 
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
Console.WriteLine("Введите координату первой точки ax: ");
int ax = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату первой точки ay: ");
int ay = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату первой точки az: ");
int az = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату первой точки bx: ");
int bx = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату первой точки by: ");
int by = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату первой точки bz: ");
int bz = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(ax-bx, 2)+ Math.Pow(ay-by, 2)+ Math.Pow(az-bz, 2));
Console.WriteLine(distance); 
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:  ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < n; i++)
{
  Console.Write(Math.Pow(i, 3) + ", ");
}
Console.Write(Math.Pow(n, 3 ));

