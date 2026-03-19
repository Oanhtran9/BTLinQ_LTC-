using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai13
{
    class students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Sorce { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tran Thi Oanh - 23115053122330");
            List<students> sinhvien = new List<students>()
            {
                new students { Id = 1,Name="An", Sorce = 6.5},
                new students { Id = 2,Name="Binh", Sorce = 7},
                new students { Id = 3,Name="Cuong", Sorce = 9},
                new students { Id = 4,Name="Dung", Sorce = 6},
                new students { Id = 5,Name="Hai", Sorce = 8.5},
                new students { Id = 6,Name="Hoa", Sorce = 7}
            };
            var svdau = sinhvien.FirstOrDefault(sv => sv.Sorce > 7);
            if (svdau != null)
            {
                Console.WriteLine($"Sinh vien dau tien co diem lon hon 7: {svdau.Name} với diem {svdau.Sorce}");
            }
            else
            {
                Console.WriteLine("Khong co sinh vien nao co diem lon hon 7.");
            }
        }
    }
}
