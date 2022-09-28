using System;
using System.Collections;
using System.Linq;

namespace Mang1chieu
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua mang:  ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            NhapMang(a, n);
            XuatMang(a, n);
            MangTang(a, n);
            Manggiam(a, n);
            ABC(a, n);
            Console.ReadLine();
        }

        static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]= ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void XuatMang(int[] a, int n)
        {
            Console.Write("Hien thi mang:\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void MangTang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                    
                }
            }
            Console.Write("\nThu tu mang tang dan la:\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
        }
        static void Manggiam(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] < a[j])
                    {
                        int tempp = a[i];
                        a[i] = a[j];
                        a[j] = tempp;
                    }
                }
            }
            Console.Write("\nThu tu mang giam dan la:\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
        }
        static void ABC(int[] a, int n)
        {
            for(int i=0; i<n-1; i++)
            {
                for(int j=i+1; j<n; j++)
                {
                    if (a[i] == a[j])
                    {
                        a[j] = a[j + 1];
                        n--;
                        i--;
                    }
                }
            }
            Console.WriteLine("\nmang sau khi bo cac so trung nhau:");
            for(int i=0; i<n; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
        }
    }
}