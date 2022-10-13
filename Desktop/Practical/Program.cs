// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// */

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }





// Задача 21 (branch task_2)
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("\n Задача 21");
// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string coorName, string pointName)
// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }

// double Decision(double x1, double x2, 
//                 double y1, double y2, 
//                 double z1, double z2){
//   return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//                    Math.Pow((y2-y1), 2) + 
//                    Math.Pow((z2-z1), 2));
// }

// double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

// Console.WriteLine($"Длина отрезка  {segmentLength}");


// {
// Console.WriteLine("Введите координаты точки А: ");
// Console.WriteLine("x: ");
// int ax = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Y: ");
// int ay = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки В: ");
// Console.WriteLine("x: ");
// int bx = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Y: ");
// int by = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки Z: ");
// Console.WriteLine("x: ");
// int zx = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Y: ");
// int zy = Convert.ToInt32(Console.ReadLine());

// int k = bx - ax;
// int m = by - ay;
// int c = zx - zy;

// double length = Math.Sqrt(k * k + m * m + c * c);
// Console.WriteLine(length);
// length = Math.Round(length, 3);
// Console.WriteLine($"Длинна {length}");
// }



//  int a_x = 1;
//  int a_y = 1;
//  int a_z = 6;
//  int b_x = 0;
//  int b_y = 0;
//  int b_z = 0;

// {
// double result = Math.Sqrt(Math.Pow(a_x- b_x, 2)
//                         +Math.Pow(a_y -b_y, 2)
//                         +Math.Pow(a_z-b_z, 2));
//  Console.WriteLine(result);

// } 



// int x1 = ReadInt("Введите координату X первой точки: ");
// int y1 = ReadInt("Введите координату Y первой точки: ");
// int z1 = ReadInt("Введите координату Z первой точки: ");
// int x2 = ReadInt("Введите координату X второй точки: ");
// int y2 = ReadInt("Введите координату Y второй точки: ");
// int z2 = ReadInt("Введите координату Z второй точки: ");

// int A = x2 - x1;
// int B = y2 - y1;
// int C = z1 - z2;

// double length = Math.Sqrt(A * A + B * B + C * C);
// Console.WriteLine($"Длинна отрезка {length}");

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// */

// int x1 = ReadInt("Введите координату X первой точки: ");
// int y1 = ReadInt("Введите координату Y первой точки: ");
// int z1 = ReadInt("Введите координату Z первой точки: ");
// int x2 = ReadInt("Введите координату X второй точки: ");
// int y2 = ReadInt("Введите координату Y второй точки: ");
// int z2 = ReadInt("Введите координату Z второй точки: ");

// int A = x2 - x1;
// int B = y2 - y1;
// int C = z1 - z2;

// double length = Math.Sqrt(A * A + B * B + C * C);
// Console.WriteLine($"Длинна отрезка {length}");


// // Функция ввода сообщения

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }



// // Задача 23
// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125
// // */

// int number = ReadInt("Введите число N: ");

// for (int i = 1; i <= number; i++)
// { 
//     Console.Write($"{i*i*i} ");
// }



// // // Функция ввода сообщения

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }