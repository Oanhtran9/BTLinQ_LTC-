using System;
using System.Collections.Generic;
using System.Linq;
namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tran Thi Oanh - 23115053122330 - 225LTC#02");
            List<int> danhsach = new List<int>();
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                danhsach.Add(rd.Next(1, 100));
            }
            Console.WriteLine("\nDanh sach so nguyen:");
            foreach (int so in danhsach)
            {
                Console.Write(so+" ");
            }
            var giamdan = danhsach.OrderByDescending(so => so);
            Console.WriteLine("\n\nDanh sach giam danh: ");
            foreach (int so in giamdan)
            {
                Console.Write(so+" ");
            }
            Console.WriteLine("\n");
        }
    }
}
