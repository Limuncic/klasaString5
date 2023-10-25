using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaString5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Unesi jedan cijeli i jedan decimalni br odvojeni razmakom: ");
            string s1 = Console.ReadLine();
            string[] rijec = s1.Split(' ');

            int br = Convert.ToInt32(rijec[0]);
            float fbr = Convert.ToSingle(rijec[1]);


            Console.WriteLine(br * 2);
            Console.WriteLine(fbr * 2);

            Console.ReadKey();
        }
    }
}
