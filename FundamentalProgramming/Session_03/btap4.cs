using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO.Pipelines;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FundamentalProgramming.Session_03
{
    //1. Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,x,/) on them and displays the result of that operation.ation.
    //2. Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
    //3. Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).
    //4. Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.  V = 4/3*π*r3
    //5. Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
    //6. Write a C# Sharp program to check whether a given number is even or odd.
    //7. Write a C# Sharp program to find the largest of three numbers.
    //8. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the point lies.
    //9. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
    //10.Write a program to read 10 numbers and find their average and sum.
    //11. Write a program to display the multiplication table of a given integer.
    //12. Write a program to display a pattern like triangles with a number.
    //13. Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + .... + 1/n
    //14. Write a program to find the ‘perfect’ numbers within a given number range.
    //15. Write a program to determine whether a given number is prime or not.

    class program
    {
        public static void Main(string[] args, int v)
        {
            //1. Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,x,/) on them and displays the result of that operation.ation.

            Console.WriteLine("Nhap so thu nhat:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap phep toan (+, -, *, /):");
            char operation = Convert.ToChar(Console.ReadLine());
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Khong the chia cho 0.");
                    break;
                default:
                    Console.WriteLine("Phep toan khong hop le.");
                    break;
            }
            Console.WriteLine($"Result: {result}");
            //2. Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
            Console.WriteLine("\nValues of the function x = y^2 + 2y + 1 for y from -5 to 5:");

            for (int i = -5; i <= 5; i++)
            {
                int resultX = i * i + 2 * i + 1;
                Console.WriteLine($"y = {i}, x = {resultX}");
            }
            //3. Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).
            Console.WriteLine("\nNhap khoang cach (km):");
            double distanceKm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap thoi gian (gio, phut, giay):");
            int hours = Convert.ToInt32(Console.ReadLine());
            int minutes = Convert.ToInt32(Console.ReadLine());
            int seconds = Convert.ToInt32(Console.ReadLine());
            double totalHours = hours + (minutes / 60.0) + (seconds / 3600.0);
            double speedKmh = distanceKm / totalHours;
            double speedMph = speedKmh * 0.621371;
            Console.WriteLine($"Toc do: {speedKmh} km/h, {speedMph} miles/h");
            //4. Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.  V = 4/3*π*r3
            Console.WriteLine("\nNhap ban kinh hinh cau (r):");
            double radius = Convert.ToDouble(Console.ReadLine());
            double surfaceArea = 4 * Math.PI * radius * radius;
            double volume = (4 / 3) * Math.PI * radius * radius * radius;
            Console.WriteLine($"Dien tich mat cau: {surfaceArea}");
            Console.WriteLine($"The tich mat cau: {volume}");
            //5. Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
            Console.WriteLine("\nNhap mot ky tu:");
            char ch = Convert.ToChar(Console.ReadLine());
            if ("aeiouAEIOU".IndexOf(ch) >= 0)
            {
                Console.WriteLine("Ky tu vua nhap la nguyen am.");
            }
            else if (char.IsDigit(ch))
            {
                Console.WriteLine("Ky tu vua nhap la chu so.");
            }
            else
            {
                Console.WriteLine("Ky tu vua nhap la ky tu khac.");
            }
            //6. Write a C# Sharp program to check whether a given number is even or odd.
            Console.WriteLine("\nNhap mot so:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("So vua nhap la so chan.");
            }
            else
            {
                Console.WriteLine("So vua nhap la so le.");
            }
            //7. Write a C# Sharp program to find the largest of three numbers.
            Console.WriteLine("\nNhap ba so:");
            int numA = Convert.ToInt32(Console.ReadLine());
            int numB = Convert.ToInt32(Console.ReadLine());
            int numC = Convert.ToInt32(Console.ReadLine());

            int largest = numA;
            if (numB > largest)
            {
                largest = numB;
            }
            if (numC > largest)
            {
                largest = numC;
            }
            Console.WriteLine($"So lon nhat trong ba so vua nhap la: {largest}");
            //8. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the point lies.
            Console.WriteLine("\nNhap toa do diem (x, y):");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Diem nam trong tu giac thu nhat.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Diem nam trong tu giac thu hai.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Diem nam trong tu giac thu ba.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Diem nam trong tu giac thu tu.");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Diem nam tren truc Oy.");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Diem nam tren truc Ox.");
            }
            else
            {
                Console.WriteLine("Diem nam tren goc toa do.");
            }
            //9. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
            Console.WriteLine("\nNhap do dai ba canh cua tam giac:");
            double sideA = Convert.ToDouble(Console.ReadLine());
            double sideB = Convert.ToDouble(Console.ReadLine());
            double sideC = Convert.ToDouble(Console.ReadLine());

            if (sideA == sideB && sideB == sideC)
            {
                Console.WriteLine("Tam giac vua nhap la tam giac deu.");
            }
            else if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                Console.WriteLine("Tam giac vua nhap la tam giac can.");
            }
            else
            {
                Console.WriteLine("Tam giac vua nhap la tam giac thuong.");
            }
            //10.Write a program to read 10 numbers and find their average and sum.
            Console.WriteLine("\nNhap 10 so:");
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                double num = Convert.ToDouble(Console.ReadLine());
                sum += num;
            }
            double average = sum / 10;
            Console.WriteLine($"Tong cua 10 so vua nhap la: {sum}");
            Console.WriteLine($"Trung binh cong cua 10 so vua nhap la: {average}");
            //11. Write a program to display the multiplication table of a given integer.
            Console.WriteLine("\nNhap mot so de hien thi bang cuu chuong:");
            int multNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Bang cuu chuong cua {multNum}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{multNum} x {i} = {multNum * i}");
            }
            //12. Write a program to display a pattern like triangles with a number.
            Console.WriteLine("\nNhap mot so de hien thi hinh tam giac:");
            int triangleNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hinh tam giac:");
            for (int i = 1; i <= triangleNumber; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            //13. Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + .... + 1/n
            Console.WriteLine("\nNhap so n de hien thi chuoi harmonic:");
            int n = Convert.ToInt32(Console.ReadLine());
            double harmonicSum = 0;
            for (int i = 1; i <= n; i++)
            {
                harmonicSum += 1.0 / i;
                Console.Write($"1/{i} ");
                if (i < n)
                {
                    Console.Write("+ ");
                }
            }
            Console.WriteLine($"\nTong cua chuoi harmonic la: {harmonicSum}");
            //14. Write a program to find the ‘perfect’ numbers within a given number range.
            Console.WriteLine("\nNhap khoang so de tim so hoan hao (tu a den b):");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Cac so hoan hao trong khoang tu {a} den {b}:");
            for (int num = a; num <= b; num++)
            {
                int sumOfDivisors = 0;
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        sumOfDivisors += i;
                    }
                }
                if (sumOfDivisors == num && num != 0)
                {
                    Console.WriteLine(num);
                }
                //15. Write a program to determine whether a given number is prime or not.
                Console.WriteLine("\nNhap mot so de kiem tra xem no co phai la so nguyen to hay khong:");
                int primeNumber = Convert.ToInt32(Console.ReadLine());
                bool isPrime = true;
                if (primeNumber <= 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(primeNumber); i++)
                    {
                        if (primeNumber % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine($"{primeNumber} la so nguyen to.");
                    }

                    else
                    {
                        Console.WriteLine($"{primeNumber} khong phai la so nguyen to.");
                    }
                }
            }
        }
    }
}






