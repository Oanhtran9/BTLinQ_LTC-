using System;
using System.Collections.Generic;
using System.Linq;
namespace Bai10
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
            var sapxep = sinhvien.OrderByDescending(s => s.Sorce);
            Console.WriteLine("\nDanh sach sinh vien sau khi sap xep:");
            foreach (var sv in sapxep)
            {
                Console.WriteLine($"Id: {sv.Id}, Name: {sv.Name}, Sorce: {sv.Sorce}");
            }
        }
    }
}
