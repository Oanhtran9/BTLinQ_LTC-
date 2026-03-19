using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tran Thi Oanh - 23115053122330");
            List<int> danhsach = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            Console.WriteLine("\nDanh sach ban dau:");
            foreach (int so in danhsach)
            {
                Console.Write(so + ", ");
            }
            var dskhongtrung = danhsach.Distinct();
            Console.WriteLine("\nDanh sach sau khi loai bo cac so trung lap:");
            foreach (int so in dskhongtrung)
            {
                Console.Write(so + ", ");
            }
        }
    }
}
