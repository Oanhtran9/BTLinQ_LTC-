using System;
using System.Collections.Generic;
using System.Linq;
namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tran Thi Oanh - 23115053122330 - 225LTC#02 ");
            List <int> danhsach = new List<int>();
            Random rd= new Random();
            for (int i = 0; i < 10; i++)
            {
                danhsach.Add(rd.Next(1, 100));
            }
            Console.WriteLine("Danh sach ngau nhien: " );
            foreach (var so in danhsach)
            {
                Console.Write(so + " ");
            }
            var sochan = danhsach.Where(so => so % 2 == 0);
            Console.WriteLine("\nTong so chan: " + sochan.Count());
        }
    }
}
