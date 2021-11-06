using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContohStatementSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilih;
            string jenis;


            Console.WriteLine("=====MENCARI LUAS DAN KELILING=====");
            Console.WriteLine("=> ketikan 1 untuk mengukur Luas persegi panjang");
            Console.WriteLine("=> ketikan 2 untuk mengukur Keliling persegi panjang");
            Console.WriteLine("=> ketikan 3 untuk mengukur Diagonal persegi panjang");
            Console.Write("PILIHAN KAMU (1/2/3)? => ");
            pilih = int.Parse(System.Console.ReadLine());
            Console.WriteLine();
            switch (pilih)
            {
                case 1:
                    int a; //panjang persegi panjang
                    double b; // lebar persegi panjang
                    double luas; // luas persegi panjang
                    Console.WriteLine("MENGHITUNG LUAS PERSEGI PANJANG");
                    Console.Write("masukkan panjang persegi panjang (cm) = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("masukkan lebar persegi panjang (cm) = ");
                    b = Convert.ToDouble(Console.ReadLine());
                    luas = a * b;
                    Console.WriteLine("luas persegi panjang  " + luas + " cm ");
                    Console.ReadKey();
                    break;

                case 2:
                    int x; //panjang persegi panjang
                    double y; // lebar persegi panjang
                    double keliling;
                    Console.WriteLine("MARI KITA MENGHITUNG LUAS PERSEGI PANJANG");
                    Console.Write("masukkan panjang persegi panjang (cm) = ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("masukkan lebar persegi panjang (cm) = ");
                    y = Convert.ToDouble(Console.ReadLine());
                    keliling = (2 * x) + (2 * y);
                    Console.WriteLine("Jumlah Keliling  " + keliling + " cm ");
                    Console.ReadKey();
                    break;

                case 3:
                    int p; //panjang persegi panjang
                    double l; // lebar persegi panjang
                    double diagonal;
                    Console.WriteLine("MARI KITA MENGHITUNG LUAS PERSEGI PANJANG");
                    Console.Write("masukkan panjang persegi panjang (cm) = ");
                    p = Convert.ToInt32(Console.ReadLine());
                    Console.Write("masukkan lebar persegi panjang (cm) = ");
                    l = Convert.ToDouble(Console.ReadLine());
                    diagonal = p * p + l * l;
                    Console.WriteLine("Jumlah diagonal  " + diagonal + " cm ");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Tidak ada pilihan selain 1/2/3");
                    break;

            }
        }
    }
}