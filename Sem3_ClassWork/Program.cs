//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int[] points = new int[2];

Console.WriteLine("Input X && Y");
for (int i=0; i< points.Length; i++)
points[i] = Convert.ToInt32(Console.ReadLine());

if (points[0] > 0 && points[1] > 0) 
Console.WriteLine ("Это первая четверть");
else if (points[0] < 0 && points[1] > 0) 
Console.WriteLine ("Это вторая четверть");
else if (points[0] < 0 && points[1] < 0) 
Console.WriteLine ("Это третья четверть");
else if (points[0] > 0 && points[1] < 0) 
Console.WriteLine ("Это четвертая четверть");
else Console.WriteLine ("X && Y =0");



