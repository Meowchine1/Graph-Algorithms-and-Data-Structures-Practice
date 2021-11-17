using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AtdGraph
{
    class Program
    {
        static void Main(string[] args)
        {

            string end = @"\data\FordBelmNeg.txt";
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            GraphType g1 = new GraphType(path+end);           
            ConsoleInterfase.Start(g1);
        }
    }
}
