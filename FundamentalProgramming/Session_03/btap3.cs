using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FundamentalProgramming.Session_03
{
    internal class btap3
    {
     //   1.Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,x,/) on them and displays the result of that operation.
     //2.Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
     //3.Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).
     //4.Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.  V = 4/3*π*r3 
     //5.Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.

        static void Main(string[] args)
        {
            //1.
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
            //2.
            Console.WriteLine("\nValues of the function x = y^2 + 2y + 1 for y from -5 to 5:");
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"y: {y}, x: {x}");
            }
            //3.
            Console.WriteLine("\nNhap khoang cach (km):");
            double distanceKm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap thoi gian (gio, phut, giay):");
            int hours = Convert.ToInt32(Console.ReadLine());
            int minutes = Convert.ToInt32(Console.ReadLine());
            int seconds = Convert.ToInt32(Console.ReadLine());
            double totalHours = hours + (minutes / 60.0) + (seconds / 3600.0);
            double speedKmh = distanceKm / totalHours;
            double speedMph = speedKmh * 0.621371;
            Console.WriteLine($"Speed: {speedKmh} km/h, {speedMph} miles/h");
            //4.
            Console.WriteLine("\nNhap ban kinh cua hinh cau:");
            double radius = Convert.ToDouble(Console.ReadLine());
            double surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Dien tich mat cau: {surfaceArea}, The tich: {volume}");
            //5.
            Console.WriteLine("\nNhap mot ky tu:");
            char character = Convert.ToChar(Console.ReadLine());
            if ("aeiouAEIOU".IndexOf(character) >= 0)
            {
                Console.WriteLine("Ky tu la nguyen am.");
            }
            else if (char.IsDigit(character))
            {
                Console.WriteLine("Ky tu la chu so.");
            }
            else
            {
                Console.WriteLine("Ky tu la ky tu dac biet.");
            }
        }
    }
}