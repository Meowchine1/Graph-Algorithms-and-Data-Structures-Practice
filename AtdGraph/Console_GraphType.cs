using System;
using System.Collections.Generic;
using System.Text;


namespace AtdGraph
{
 public  class Console_GraphType 
    {
        public static void AddTop(GraphType graph, string top)
        {
           
            try
            {
                graph.AddTop(top);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static void DeleteTop(GraphType graph, string top)
        {
            
            try
            {
                graph.DeleteTop(top);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public static void AddEdge(GraphType graph, string startTop, string endTop)
        {
          
            try
            {
                graph.AddEdge(startTop, endTop);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void AddEdge(GraphType graph, string startTop, string endTop, double weight)
        {
           
            try
            {
                graph.AddEdge(startTop, endTop, weight);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
       
        public static void DeleteEdge(GraphType graph, string startTop, string endTop)
        {
           
            try
            {
                graph.DeleteEdge(startTop,endTop);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
        public static void Show(GraphType graph)
        {
            Console.WriteLine((graph.Orientation ? "" : "No") + " orientation / " + (graph.Weighted ? "" : "No") + "weighted\n");

            if (graph.Graph.Count != 0)
            {

                foreach (var vs in graph.Graph)
                {
                    Console.Write($"{vs.Key} | ");
                    foreach (var v in vs.Value)
                    {
                        if (graph.Weighted)
                        {
                            Console.Write($"{{{v.Key}, {v.Value}}} ");
                        }
                        else
                        {
                            Console.Write($"{{{v.Key}}} ");
                        }
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Граф не содержит элементов.");
            }

        }
        public static int  GetIshodDegree(GraphType graph, string node) 
        {

            try
            {
                return graph.GetIshodDegree(node);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return 0;
        }

        public static List<string> CanGetNodeThroughOneNode(GraphType g, string start, string end)
        {
            List<string> t = new List<string>();
            try
            {
                return g.CanGetNodeThroughOneNode(start, end);

            }
            catch (Exception e)
            
            {
                Console.WriteLine(e.Message);
            }
            return t;
        
        }

      

        public static void BFS(GraphType g, string v, ref List<string> res, List<string> stoptop)
        {
            res = new List<string>();
            g.BFS(v, ref res, stoptop);

        }


        public static bool Acycle(GraphType g, string v)
        {
            g.Acycle_start(v);
            if (g.Color.ContainsValue(GraphType.Colors.black))
            {
                return false;
            }
            else return true;
        
        }

        public static List<Edje> Kraskal(GraphType g)
        {
            return g.Kraskal();
        }

        public static Dictionary<string, double> Djkstra(GraphType g, string v) {

            return g.Dijkstra(v);
        }

        public static Dictionary<string, double> Djkstra_4A8(GraphType g, string v, double n)
        {
            Dictionary<string, double> tmp =  g.Dijkstra(v);
            Dictionary<string, double> res = new Dictionary<string, double>();
            foreach (var elem in tmp)
            {
                if (elem.Value <= n)
                {
                    res.Add(elem.Key, elem.Value);
                }
            
            }
            return res;
        }

        public static string FordBel(GraphType g, string startV, string endV, int maxSize)
        {
            string result = ""; 
            List<string> path = g.FordBel(startV, endV);
            if (path.Count == 0)
            {
                result = "Way is unreal";

            }
            else
            {
                if (path.Count > maxSize - 1)
                {
                    result = "Size limit error";
                }
                else
                {
                    foreach (var elem in path)
                    {
                        result += elem + "=>";
                    }
                   
                }


            }
            return result;
        }

    }
}
