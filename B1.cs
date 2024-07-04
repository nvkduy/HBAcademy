using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBAcademy
{
    internal class B1
    {
        public static void Y1()
        {
            string s = "HB AcademyH";
            bool so = false;
            bool dx = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    so = true;
                }
                Console.Write(s[i]);
            }
            Console.WriteLine();
            if (so)
            {
                Console.WriteLine("Co ky tu so");
            }
            else
            {
                Console.WriteLine("Ko co ky tu so");
            }
            //s.Contains("ca");

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                    dx = false;
            }
            if (dx)
            {
                Console.Write("chuoi doi xung");
            }
            else
            {
                Console.Write("chuoi ko doi xung");
            }
        }
        public static void Y2()
        {
            StringBuilder s1 = new StringBuilder();
            StringBuilder s2 = new StringBuilder("HB Academy");
            s1.Append("Cong Hoa Xa Hoi");
            s1.Append("ê");
            s2.Insert(3, "2022 ");
            Console.WriteLine(s2);
            s2.Remove(3, 5);
            Console.WriteLine(s2);
            for (int i = 0; i < s2.Length; i++)
            {
                if (s2[i] == 'B')
                    s2[i] = 'b';
            }
            Console.WriteLine(s2);
        }
        public static void Y3()
        {
            StringBuilder name = new StringBuilder("  NguyEn  VaN huNg  ");
            //StringBuilder name1 = new StringBuilder("  NguyEn  VaN huNg");
            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (name[i] > ' ')
            //        name.Remove[i, 1];
            //}
            //Console.WriteLine(name);
            //string[] name2 = name1.ToString().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            //foreach (string s in name2)
            //{
            //    Console.WriteLine(s);
            //}
            //xoa ky tu trang dau
            while (name[0] == ' ')
            {
                name.Remove(0, 1);
            }
            Console.WriteLine(name);
            //xoa ky tu trang cuoi
            while (name[name.Length-1]==' ')
            {
                name.Remove(name.Length-1, 1);
            }
            Console.WriteLine(name);
            //xoa ky tu giua
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == ' ')
                {
                    while (name[i + 1] == ' ')
                    {
                        name.Remove(i+1, 1);
                    }
                }
            }
            //Chuyen chu hoa thanh chu thuong
            Console.WriteLine(name);
            for (int i = 0; i < name.Length; i++)
                if (name[i] >= 'A' && name[i] <= 'Z')
                {
                    name[i] = (char)(name[i]+32);
                }
            Console.WriteLine(name);
            //sau dau cach chuyen thanh chu hoa
            bool khoangtrang=true;
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
