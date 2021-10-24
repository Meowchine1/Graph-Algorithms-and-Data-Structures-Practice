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

    }
}
