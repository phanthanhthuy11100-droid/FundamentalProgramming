using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.Session_02
{
    internal class Ex
    {
        /* 
         1.	Divide Two Numbers
        2.	Specified Operations Results
        3.	Multiply Three Numbers
        4.	Arithmetic Operations
        5.	Multiplication Table
        6.	Average of Four Numbers
        7.	Specified Formula with Three Numbers
        8.	Print Age Message
        9.	Repeat Number in Rows
        10.	Rectangle Pattern with Number
        11.	Remove Character by Index
        12.	Swap First and Last Characters
        13.	Add First Character to Front and Back
        14.	Check Positive and Negative Pair
        15.	Sum or Triple Sum of Integers
        16.	Check for 20 or Sum Equals 20
        17.	Check Within 20 of 100 or 200
        18.	Convert String to Lowercase
        19.	Print Odd Numbers 1 to 99
        20.	Sum of First 500 Primes

        */
        static void Main(string[] args)
        {
            //1.	Divide Two Numbers
            Console.WriteLine("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Tong: " + (a + b));
            Console.WriteLine("Hieu: " + (a - b));
            Console.WriteLine("Tich: " + (a * b));
            if (b != 0)
            {
                Console.WriteLine("Thuong: " + (a / b));
            }
            else
            {
                Console.WriteLine("Khong the chia cho 0");
            }
            //2.	Specified Operations Results
            Console.WriteLine("Nhap so c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so d: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Ket qua cua c + d la: " + (c + d));
            Console.WriteLine("Ket qua cua c - d la: " + (c - d));
            if (d != 0)
            {
                Console.WriteLine("Ket qua cua c / d la: " + (c / d) + " " + (d / d));
            }
            else
            {
                Console.WriteLine("Khong the chia cho 0");
            }
            Console.WriteLine("Ket qua cua c * d la: " + (c * d));
            //3.	Multiply Three Numbers
            Console.WriteLine("Nhap so thu nhat: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu ba: ");
            int num3 = int.Parse(Console.ReadLine());
            int result = num1 * num2 * num3;
            Console.WriteLine("Ket qua: " + result);
            //4.	Arithmetic Operations
            Console.WriteLine("Nhap so e: ");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so f: ");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Tong: " + (e + f));
            Console.WriteLine("Hieu: " + (e - f));
            Console.WriteLine("Tich: " + (e * f));
            if (f != 0)
            {
                Console.WriteLine("Thuong: " + (e / f) + " " + (f / f));
            }
            else
            {
                Console.WriteLine("Khong the chia cho 0");
            }
            //5.	Multiplication Table
            Console.WriteLine("Nhap so: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Bang cuu chuong cua " + num + ":");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }
            //6.	Average of Four Numbers
            Console.WriteLine("Nhap so thu tu: ");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu nam: ");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu sau: ");
            int num6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu bay: ");
            int num7 = int.Parse(Console.ReadLine());
            double average = (num4 + num5 + num6 + num7) / 4;
            Console.WriteLine("Trung binh cong cua bon so la: " + average);
            //7.	Specified Formula with Three Numbers
            Console.WriteLine("Nhap so thu nhat: ");
            double g = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu ba: ");
            double l = double.Parse(Console.ReadLine());
            double ketqua = (g + h) * l;
            Console.WriteLine("Ket qua cua bieu thuc (a + b) * c la: " + ketqua);
            //8.	Print Age Message
            Console.WriteLine("Nhap tuoi cua ban: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Ban co ve gia hon " + age);
            //9.	Repeat Number in Rows
            Console.WriteLine("Nhap mot so: ");
            int number = int.Parse(Console.ReadLine());
            // Using Console.Write
            for (int p = 0; p < 4; p++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            // Using {0}
            for (int k = 0; k < 4; k++)
            {
                Console.Write("{0}", number);
            }
            Console.WriteLine();
            //10.	Rectangle Pattern with Number
            Console.WriteLine("Nhap mot so: ");
            int so = int.Parse(Console.ReadLine());
            for (int n = 0; n < 5; n++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(so + " ");
                }
                Console.WriteLine();
                //11.	Remove Character by Index
                Console.WriteLine("Nhap mot chuoi: ");
                string input = Console.ReadLine();
                Console.WriteLine("Nhap chi so can xoa: ");
                int index = int.Parse(Console.ReadLine());
                if (index >= 0 && index < input.Length)
                {
                    string kq = input.Remove(index, 1);
                    Console.WriteLine("Chuoi sau khi xoa ky tu tai chi so " + index + ": " + kq);
                }
                else
                {
                    Console.WriteLine("Chi so khong hop le");
                    //12.	Swap First and Last Characters
                    Console.WriteLine("Nhap mot chuoi: ");
                    string dauvao = Console.ReadLine();
                    if (dauvao.Length > 1)
                    {
                        char firstChar = dauvao[0];
                        char lastChar = dauvao[dauvao.Length - 1];
                        string kq = lastChar + dauvao.Substring(1, dauvao.Length - 2) + firstChar;
                        Console.WriteLine("Chuoi sau khi doi ky tu dau va cuoi: " + kq);
                    }
                    else
                    {
                        Console.WriteLine("Chuoi qua ngan de doi ky tu");
                        //13.	Add First Character to Front and Back
                        Console.WriteLine("Nhap mot chuoi: ");
                        string dvv = Console.ReadLine();
                        if (dvv.Length > 0)
                        {
                            char firstChar = dvv[0];
                            string kq = firstChar + dvv + firstChar;
                            Console.WriteLine("Chuoi sau khi them ky tu dau vao dau va cuoi: " + kq);
                        }
                        else
                        {
                            Console.WriteLine("Chuoi khong duoc de trong");
                            //14.	Check Positive and Negative Pair
                            Console.WriteLine("Nhap so thu nhat: ");
                            int num10 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nhap so thu hai: ");
                            int num11 = int.Parse(Console.ReadLine());
                            if ((num10 > 0 && num11 < 0) || (num10 < 0 && num11 > 0))
                            {
                                Console.WriteLine("Hai so la mot cap doi duong am");
                            }
                            else
                            {
                                Console.WriteLine("Hai so khong phai la mot cap doi duong am");
                                //15.	Sum or Triple Sum of Integers
                                Console.WriteLine("Nhap so thu nhat: ");
                                int num12 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Nhap so thu hai: ");
                                int num13 = int.Parse(Console.ReadLine());
                                if (num12 == num13)
                                {
                                    Console.WriteLine("Ket qua la: " + (num12 + num13) * 3);
                                }
                                else
                                {
                                    Console.WriteLine("Ket qua la: " + (num12 + num13));
                                    //16.	Check for 20 or Sum Equals 20
                                    Console.WriteLine("Nhap so thu nhat: ");
                                    int num14 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Nhap so thu hai: ");
                                    int num15 = int.Parse(Console.ReadLine());
                                    if (num14 == 20 || num15 == 20 || (num14 + num15) == 20)
                                    {
                                        Console.WriteLine("Ket qua la: true");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ket qua la: false");
                                        //17.	Check Within 20 of 100 or 200
                                        Console.WriteLine("Nhap so: ");
                                        int numb = int.Parse(Console.ReadLine());
                                        if (Math.Abs(100 - numb) <= 20 || Math.Abs(200 - numb) <= 20)
                                        {
                                            Console.WriteLine("Ket qua la: true");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ket qua la: false");
                                            //18.	Convert String to Lowercase
                                            Console.WriteLine("Nhap mot chuoi: ");
                                            string ddv = Console.ReadLine();
                                            string kq = ddv.ToLower();
                                            Console.WriteLine("Chuoi sau khi chuyen sang chu thuong: " + kq);
                                            //19.	Print Odd Numbers 1 to 99
                                            Console.WriteLine("Cac so le tu 1 den 99:");
                                            for (int x = 1; x < 100; x += 2)
                                            {
                                                Console.Write(x + " ");
                                            }
                                            Console.WriteLine();
                                            //20.	Sum of First 500 Primes
                                            int count = 0;
                                            int nmb = 2;
                                            long sum = 0;
                                            while (count < 500)
                                            {
                                                if (IsPrime(nmb))
                                                {
                                                    sum += nmb;
                                                    count++;
                                                }
                                                nmb++;
                                            }
                                            Console.WriteLine("Tong cua 500 so nguyen to dau tien la: " + sum);
                                        }
                                        static bool IsPrime(int number)
                                        {
                                            if (number <= 1) return false;
                                            for (int f = 2; f <= Math.Sqrt(number); f++)
                                            {
                                                if (number % f == 0) return false;
                                            }
                                            return true;
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}















