using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tran Thi Oanh - 23115053122330 - 225LTC#02");
            List<int> numbers=new List<int> { 1,2,3,4,5,6,7,8,9,10};
            var solonhon5 = numbers.Where(so => so > 5);
            Console.WriteLine("\ndanh sach so lon hon 5:");
            foreach(var so in solonhon5)
            {
                Console.WriteLine(so);
            }
        }
    }
}
