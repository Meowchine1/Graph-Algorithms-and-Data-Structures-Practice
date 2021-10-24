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
            /* GraphType<string> g1 = new GraphType<string>(@"D:\Программирование\341\Теория графов\Реализация графа\InputFiles\nondirected nonweight.txt");
             GraphType<string> g2 = new GraphType<string>(@"D:\Программирование\341\Теория графов\Реализация графа\InputFiles\nondirected Weight.txt");
             GraphType<string> g3 = new GraphType<string>(@"D:\Программирование\341\Теория графов\Реализация графа\InputFiles\Directed Weight.txt");
             GraphType<string> g4 = new GraphType<string>(@"D:\Программирование\341\Теория графов\Реализация графа\InputFiles\Directed nonweight.txt");


              g1.Show();
              g1.AddEdge("a","e", 0 );
              g1.Show();

              g1.DeleteEdge("a","b");
              g1.AddTop("k");
              g1.Show();


              g2.Show();
              g3.Show();
              g4.Show();

              */
            //DirectedNonweighted
            //DirectedWeighted
            //NondirectedWeighted
            //notD notW 
            //nw nd
            string end = @"\data\NondirectedWeighted.txt";
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string end2 = @"\data\notD notW .txt";
            GraphType g1 = new GraphType(path+end);
            GraphType g2 = new GraphType(path + end2);
            g1.Obedinenie(g2);
           
            ConsoleInterfase.Start(g1);
        }
    }
}
