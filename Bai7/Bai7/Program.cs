using System;
using System.Collections.Generic;
using System.Linq;
namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tran Thi Oanh - 23115053122330");
            List <int> danhsach=new List<int>();
            Random rd=new Random();
            for (int i = 0; i < 10; i++)
            {
                danhsach.Add(rd.Next(1, 100));
            }
            Console.WriteLine("Danh sach so nguyen:");
            foreach (int so in danhsach)
            {
                Console.WriteLine(so);
            }
            var kiemtra = danhsach.Any(So => So > 10);
            if(kiemtra)
            {
                Console.WriteLine("Co so lon hon 10");
            }
            else
            {
                Console.WriteLine("Khong co so lon hon 10");
            }

        }
    }
}
