using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tran Thi Oanh - 23115053122330-225LTC#02");
            List<int> danhsach = new List<int>();
            Random ds = new Random();

            for (int i = 0; i < 10; i++)
            {
                danhsach.Add(ds.Next(1, 10));
            }
            Console.WriteLine("\nDanh sach:");
            foreach (var so in danhsach)
            {
                Console.Write(so + " ");
            }
            var max = danhsach
               .GroupBy(so => so)
               .Select(n => new { so = n.Key, Dem = n.Count() })
               .OrderByDescending(so => so.Dem)
               .First();
            Console.WriteLine("\n\nSo xuat hien nhieu nhat: " + max.so);
            Console.WriteLine("So lan: " + max.Dem);
        }
    }
}
