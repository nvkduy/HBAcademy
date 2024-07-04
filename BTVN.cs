using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBAcademy
{
    internal class BTVN
    {
        public static void Y1()                      
        {
             // Kiểm tra mảng số nguyên
             int[] numbers = { 1, 2, 3, 4, 5 };
             Console.WriteLine(Contains(numbers, 1)); // Output: True
             Console.WriteLine(Contains(numbers, 9)); // Output: False

             // Kiểm tra chuỗi
             string text = "HB Academy!";
             Console.WriteLine(Contains(text, 'A')); // Output: True
             Console.WriteLine(Contains(text, 'z')); // Output: False
        }

            // Hàm Contains cho mảng số nguyên
            public static bool Contains(int[] array, int value)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == value)
                    {
                        return true;
                    }
                }
                return false;
            }

            // Hàm Contains cho chuỗi
            public static bool Contains(string str, char value)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == value)
                    {
                        return true;
                    }
                }
                return false;
            }
        public static void Y2()
        {
            //Khai bao bien
            string str;
            int chuCaiH = 0, chuCaiT = 0, chuSo = 0, kyTuDacBiet = 0, i = 0, l;

            // Nhap chuoi
            Console.Write("\nDem so chu cai, so chu so, so ky tu dac biet cua chuoi trong C#:\n");
            Console.Write("--------------------------------------------------------------------\n");
            Console.Write("Nhap chuoi:");
            str = Console.ReadLine();
            l = str.Length;

            //// Kien tra ky tu trong chuoi
            chuCaiT = str.Count(C => (C >= 'a' && C <= 'z'));
            chuCaiH=str.Count(c=>(c>='A'&&c<='Z'));
            chuSo = str.Count(c => (c >= '0' && c <= '9'));
            kyTuDacBiet=l-chuCaiH-chuCaiT-chuSo-kyTuDacBiet;
            //while (i < l)
            //{
            //    if (str[i] >= 'a' && str[i] <= 'z')
            //    {
            //        chuCaiT++; //dem chu cai thuong
            //    }
            //    else if (str[i] >= 'A' && str[i] <= 'Z')
            //    {
            //        chuCaiH++; // demchu cai hoa
            //    }
            //    else if (str[i] >= '0' && str[i] <= '9')
            //    {
            //        chuSo++; // dem so
            //    }
            //    else
            //    {
            //        kyTuDacBiet++; // dem ky tu dac biet
            //    }
            //    i++;
            //}

            // in ra
            Console.Write("So chu cai thuong trong chuoi la: {0}\n", chuCaiT);
            Console.Write("So chu cai hoa trong chuoi la: {0}\n", chuCaiH);
            Console.Write("So chu so trong chuoi la: {0}\n", chuSo);
            Console.Write("So ky tu dac biet trong chuoi la: {0}\n\n", kyTuDacBiet);
        }

    }
}

