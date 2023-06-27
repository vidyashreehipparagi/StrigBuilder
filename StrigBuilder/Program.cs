

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrigBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello to all");
            StringBuilder sb2 = new StringBuilder(20);
            Console.WriteLine(sb);
            Console.WriteLine(sb.GetHashCode());
            Console.WriteLine("_______________________");
            sb.Append(" Good Morning");
            Console.WriteLine(sb);
            Console.WriteLine(sb2.GetHashCode());
            Console.WriteLine("________________________");
            sb.Insert(5, " TEST DATA");
            Console.WriteLine(sb);
            Console.WriteLine("__________________________");
            sb.Replace("DATA", "new data");
            Console.WriteLine(sb);
            Console.WriteLine("___________________________");
            StringBuilder sb3= new StringBuilder("Your amount is");
            sb3.AppendFormat("{0:C}", 25000);
            Console.WriteLine(sb3);
        }
    }
}
