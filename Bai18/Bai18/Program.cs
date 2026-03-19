using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai18
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
            Console.WriteLine("Tran Thi Oanh - 23115053122330-225LTC#02");
            List<students> sinhvien = new List<students>()
            {

                new students { Id = 1,Name="An", Score = 8},
                new students { Id = 2,Name="Binh", Score = 7},
                new students { Id = 3,Name="Cuong", Score = 9},
                new students { Id = 4,Name="Dung", Score = 6},
                new students { Id = 5,Name="Em", Score = 5}
            };
            var nhom = sinhvien.GroupBy(s =>s.Score>= 8 ?"Gioi":s.Score >=6?"Kha":"Trung Binh");
            foreach (var sv in nhom)
            {
                Console.WriteLine($"\nNhom: {sv.Key}");
                foreach (var s in sv)
                {
                    Console.WriteLine($"Id: {s.Id}, Name: {s.Name}, Score: {s.Score}");
                }
            }
        }
    }
}
