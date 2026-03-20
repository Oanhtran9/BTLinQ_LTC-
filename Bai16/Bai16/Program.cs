using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tran Thi Oanh - 23115053122330 - 225LTC#02 ");
            List<int> danhsach = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            Console.WriteLine("\nDanh sach ban dau:");
            foreach (var so in danhsach)
            {
                Console.Write(so + " ");
            }
            var tong = danhsach.Sum(so => so);
            Console.WriteLine("\n\nTong cac so trong danh sach: " + tong);
        }
    }
}
