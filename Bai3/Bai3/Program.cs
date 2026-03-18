using System;
using System.Collections.Generic;
using System.Linq;
namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tran Thi Oanh - 23115053122330");
            List<int>danhsach=new List<int> {6,3,9,1,7,-1,5,2,-5,8,5};
            
            Console.WriteLine("\nDanh sach: ");
            foreach(int i in danhsach)
            {
                Console.Write(i+" ");
            }
            var tangdan=danhsach.OrderBy(so=>so);
            Console.WriteLine("\n\nDanh sach so tang dan: ");
            foreach(int i in tangdan)
            {
                Console.Write(i+" ");
            }
        }
    }
}
