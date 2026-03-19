using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai20
{
    class students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tran Thi Oanh - 23115053122330 - 225LTC#02");
            List<students> sinhvien = new List<students>()
            {
                new students { Id = 1,Name="An", Score = 8},
                new students { Id = 2,Name="Binh", Score = 7},
                new students { Id = 3,Name="Cuong", Score = 9},
                new students { Id = 4,Name="Dung", Score = 6},
                new students { Id = 5,Name="Em", Score = 10},
                new students { Id = 6,Name="Phuc", Score = 5},
                new students { Id = 7,Name="Hai", Score = 4}
            };
            var sapxep = sinhvien.OrderBy(sv => sv.Score);
            Console.WriteLine("\nDanh sach sinh vien sau khi sap xep theo diem tang dan:");
            foreach (var sv in sapxep)
            {
                Console.WriteLine($"Id: {sv.Id}, Name: {sv.Name}, Score: {sv.Score}");
            }
            var top3 = sinhvien.OrderByDescending(sv => sv.Score).Take(3);
            Console.WriteLine("\nDanh sach 3 sinh vien co diem cao nhat:");
            foreach (var sv in top3)
            {
                Console.WriteLine($"Id: {sv.Id}, Name: {sv.Name}, Score: {sv.Score}");
            }
        }
    }
}
