// Домашняя работа

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом 

/*
Console.WriteLine("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N <= 9999 || N >= 100000)
{
    Console.WriteLine("Число не пятизначное!");
    return;
}
if (N / 10000 == N % 10 && (N / 1000)%10 == (N % 100)/10)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}
*/
//------------------------------------------------------

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве

/*
Console.Write ("Введите координату точки А по оси Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите координату точки А по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите координату точки C по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите координату точки B по оси Х: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите координату точки B по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите координату точки C по оси Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
Console.WriteLine(Math.Round(result,2));
*/
//---------------------------------------------------------------------

// Задача 23
// Напишите программу, которая принимает на вход число N
// и выдает таблицу кубов чисел от 1 до N

/*
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, 3) + "\t");
}
*/

// Доп. задание №1
// Представим банк, в котором алгоритм начисления процента по вкладу зависит от суммы вклада. 
// На вход будет подаваться число (сумма вклада). При значении меньше 100, будет начислено 5 %, 
// если значение находится в диапазоне от ста до двухсот — 7 %, если больше — 10 %. Отработав, 
// программа должна вывести общую сумму с начисленными процентами.

/*
Console.WriteLine("Введите сумму вклада: ");
int sum = Convert.ToInt32(Console.ReadLine());

if (sum >= 0 && sum <= 100)
{
    Console.WriteLine($"Сумма с процентами: {sum + sum*0.05}");
}
else if (sum > 100 && sum <= 200)
{
    Console.WriteLine($"Сумма с процентами: {sum + sum*0.07}");
}
else if (sum > 200)
{
    Console.WriteLine($"Сумма с процентами: {sum + sum*0.1}");
}
else
{
    Console.WriteLine("Сумма вклада не может быть отрицательной!");
}
*/

