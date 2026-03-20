using System;
using System.Collections.Generic;
using System.Linq;
namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tran Thi Oanh - 23115053122330-225LTC#02 ");
            List <int> danhsach=new List<int>();
            Random rd=new Random();
            for (int i = 0; i < 10; i++)
            {
                danhsach.Add(rd.Next(1, 100));
            }
            Console.WriteLine("Danh sach so nguyen:");
            foreach (int so in danhsach)
            {
                Console.Write(so+" ");
            }
            var kiemtra = danhsach.Any(So => So > 10);
            if(kiemtra)
            {
                Console.WriteLine("\n\nCo so lon hon 10");
            }
            else
            {
                Console.WriteLine("\nKhong co so lon hon 10");
            }
        }
    }
}
