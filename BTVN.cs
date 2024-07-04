using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HBAcademy
{
    internal class BTVN
    {
        public static void Y1()                      
        {
             //Kiem tra mang sso nguyen
             int[] numbers = { 1, 2, 3, 4, 5 };
             Console.WriteLine(Contains(numbers, 1)); 
             Console.WriteLine(Contains(numbers, 9)); 

             //Kiem tra chuoi
             string text = "HB Academy!";
             Console.WriteLine(Contains(text, 'A')); 
             Console.WriteLine(Contains(text, 'z')); 
        }

            //Ham Contains cho mang so nguyen
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

            //Ham Contains cho chuoi
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

            // Kien tra ky tu trong chuoi
            //Dung count
            chuCaiT = str.Count(C => (C >= 'a' && C <= 'z'));
            chuCaiH=str.Count(c=>(c>='A'&&c<='Z'));
            chuSo = str.Count(c => (c >= '0' && c <= '9'));
            kyTuDacBiet=l-chuCaiH-chuCaiT-chuSo-kyTuDacBiet;
            //Dung vong lap
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
        public static void Y3()
        {
            StringBuilder name = new StringBuilder("  NguyEn  VaN huNg  ");
            while (name[0] == ' ')
            {
                name.Remove(0, 1);
            }
            Console.WriteLine(name);
            //xoa ky tu trang cuoi
            while (name[name.Length - 1] == ' ')
            {
                name.Remove(name.Length - 1, 1);
            }
            Console.WriteLine(name);
            //xoa ky tu giua
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == ' ')
                {
                    while (name[i + 1] == ' ')
                    {
                        name.Remove(i + 1, 1);
                    }
                }
            }
            //Chuyen chu hoa thanh chu thuong
            Console.WriteLine(name);
            for (int i = 0; i < name.Length; i++)
                if (name[i] >= 'A' && name[i] <= 'Z')
                {
                    name[i] = (char)(name[i] + 32);
                }
            Console.WriteLine(name);
            //sau dau cach chuyen thanh chu hoa
            bool khoangtrang = true;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == ' ')
                {
                    khoangtrang = true;
                }
                else if (khoangtrang && name[i] >= 'a' && name[i] <= 'z')
                {
                    name[i] = (char)(name[i] - 32);
                    khoangtrang = false;

                }
                else
                {
                    khoangtrang = false;

                }
            }
            Console.WriteLine(name);
        }

    }
}

