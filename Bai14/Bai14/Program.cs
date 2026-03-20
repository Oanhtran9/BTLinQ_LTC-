using System;
using System.Collections.Generic;
using System.Linq;
namespace Bai14
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
                new students { Id = 1,Name="An", Sorce = 6.5},
                new students { Id = 2,Name="Binh", Sorce = 7},
                new students { Id = 3,Name="Cuong", Sorce = 4.5},
                new students { Id = 4,Name="Dung", Sorce = 6},
                new students { Id = 5,Name="Hai", Sorce = 8.5},
                new students { Id = 6,Name="Hoa", Sorce = 3}
            };
            var kiemtra = sinhvien.Where(sv => sv.Sorce < 5);
            if (kiemtra.Count() == 0)
            {
                Console.WriteLine("\nKhong co sinh vien nao bi rot");
            }
            else
            {
                Console.WriteLine("\nDanh sach sinh vien bi rot:");
                foreach (var sv in kiemtra)
                {
                    Console.WriteLine($"Id: {sv.Id}, Name: {sv.Name}, Sorce: {sv.Sorce}");
                }
            }
        }
    }
}
