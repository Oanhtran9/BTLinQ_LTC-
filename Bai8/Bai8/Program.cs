using System;
using System.Collections.Generic;
using System.Linq;
namespace Bai8
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tran Thi Oanh - 23115053122330 - 225LTC#02 ");
            List<Student> students = new List<Student>()
            {   new Student { Id = 1, Name = "An", Score = 8 },
                new Student { Id = 2, Name = "Binh", Score = 6 },
                new Student { Id = 3, Name = "Chi", Score = 9 },
                new Student { Id = 4, Name = "Dung", Score = 7 }
            };
            var svgioi = students.FindAll(sv => sv.Score >= 8);
            Console.WriteLine("\nDanh sach sinh vien co diem >= 8:");
            foreach (var sv in svgioi)
            {
                Console.WriteLine($"Id: {sv.Id}, Name: {sv.Name}, Score: {sv.Score}");
            }
        }
    }
}
