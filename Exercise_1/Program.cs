using System;
using System.Globalization;

namespace Exercise_1
{
    class Program
    {
        private int[] a = new int[20];

        private int n;
        private string s;

        public void read()
        {
            while (true)
            {
                Console.Write("Masukkan Elemen Pada Array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 2)
                    break;
                else
                    Console.WriteLine("");

            }
            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("------------------------");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1, i + 1, i + 1, i - 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void Display()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------");
            for (int j = 2; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
           
        }

        public void Array()
        {
            for ( int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program myList = new Program();

            myList.read();
            myList.Array();
            myList.Display();
            Console.WriteLine("\n\n Tekan Enter Untuk Keluar.");
        }
    }
}