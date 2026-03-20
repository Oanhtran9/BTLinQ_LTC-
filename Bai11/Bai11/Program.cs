using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai11
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
            Console.WriteLine("Tran Thi Oanh - 23115053122330 - 225LTC#02 ");
            List<students> sinhvien = new List<students>()
            {
                new students { Id = 1,Name="An", Sorce = 8},
                new students { Id = 2,Name="Binh", Sorce = 7},
                new students { Id = 3,Name="Cuong", Sorce = 9},
                new students { Id = 4,Name="Dung", Sorce = 6}
            };
            foreach (var sv in sinhvien)
            {
                Console.WriteLine($"Id: {sv.Id} - Name: {sv.Name} - Sorce: {sv.Sorce}");
            }
            var topsv = sinhvien.Max(sv => sv.Sorce);
            foreach (var sv in sinhvien)
            {
                if (sv.Sorce == topsv)
                {
                    Console.WriteLine($"\nSinh vien co diem cao nhat la: {sv.Name} - diem {sv.Sorce}");
                }
            }
        }
    }
}
