using System;
using System.Collections.Generic;
using System.Linq;
namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tran Thi Oanh - 23115053122330-225LTC#02 ");
            List<int> danhsach = new List<int>();
            Random rd = new Random();
            for (int i = 1; i < 5; i++)
            {
                danhsach.Add(rd.Next(1, 10));
            }
            Console.WriteLine("\nDanh sach ngau nhien: ");
            foreach (var so in danhsach)
            {
                Console.WriteLine(so);
            }
            var binhphuong = danhsach.Select(so => so * so);
            Console.WriteLine("\nBinh phuong cua cac so: ");
            foreach (var so in binhphuong)
            {
                Console.WriteLine(so);
            }
        }
    }
}
