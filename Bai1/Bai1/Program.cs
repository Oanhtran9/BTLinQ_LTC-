using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tran Thi Oanh - 23115053122330");
            List <int> numbers = new List<int> { 1,2,3,4,5,6,7,8};
            var sochan = numbers.Where(so=>so%2==0);
            Console.WriteLine("\nSo chan trong danh sach: ");
            foreach(var so in sochan )
            {
                Console.WriteLine(so);
            }
        }
    }
}
