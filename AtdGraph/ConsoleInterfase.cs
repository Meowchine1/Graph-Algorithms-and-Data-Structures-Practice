﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AtdGraph
{
  public class ConsoleInterfase
    {
        static GraphType graph;
        static int action = 0;
        public static void Start(GraphType graphNew)
        {
            graph = graphNew;
            ShowMenu();
            Console.WriteLine();
            while (action != 7)
            {
                ReadKey();
                SwitchAction(action);
            }
        }
        static void ShowMenu()
        {
            Console.WriteLine("1. Добавить вершину.\n" +
                              "2. Добавить ребро.\n" +
                              "3. Удалить вершину.\n" +
                              "4. Удалить ребро.\n" +
                              "5. Показать список смежности.\n" +
                              "6. Показать меню\n" +
                              "7. Выйти из программы\n"+
                              "8 Степень исхода\n"+
                              "9 CanGetNodeThroughOneNode\n"+
                              "10 DFS FindWay Without {V}\n+" +
                              "11 test bfs");
        }
        static void ReadKey()
        {
            Console.WriteLine("Введите номер действия, который вы хотите выполнить:" +
                "(6 - Показать меню ) ");
            try
            {
                action = int.Parse(Console.ReadLine());
            }
            catch
            {
                action = 0;
            }

        }
        static void SwitchAction(int i)
        {
            switch (i)
            {
                case (1):
                    {
                        Console.WriteLine("Введите название новой вершины: ");
                       
                        Console_GraphType.AddTop(graph, Console.ReadLine());
                        Console.WriteLine();
                        break;
                    }
                case (2):
                    {
                        if (graph.Weighted)
                        {
                            Console.WriteLine("Введите название двух вершин через пробел и вес (1-ая - откуда, 2-ая - куда и вес):");
                            string[] temp = Console.ReadLine().Split(' ');
                            Console_GraphType.AddEdge(graph, temp[0], temp[1], double.Parse(temp[2]));    

                        }
                        else
                        {
                            Console.WriteLine("Введите название двух вершин через пробел (1-ая - откуда, 2-ая - куда):");
                            string[] temp = Console.ReadLine().Split(' ');
                            Console_GraphType.AddEdge(graph, temp[0], temp[1]);
                        }
                        Console.WriteLine();
                        break;
                    }
                case (3):
                    {
                        Console.WriteLine("Введите название вершины которую хотите удалить:");     
                        Console_GraphType.DeleteTop(graph, Console.ReadLine());
                        Console.WriteLine();
                        break;
                    }
                case (4):
                    {
                        Console.WriteLine("Введите название двух вершин через пробел(1-ая - откуда, 2-ая - куда):");
                        string[] temp = Console.ReadLine().Split(' ');
                        Console_GraphType.DeleteEdge(graph, temp[0], temp[1]);
                        Console.WriteLine();
                        break;
                    }
                case (5):
                    {
                        Console.WriteLine();
                        Console_GraphType.Show(graph);
                        Console.WriteLine();
                        break;
                    }
                case (6):
                    {
                        Console.WriteLine();
                        ShowMenu();
                        Console.WriteLine();
                        break;
                    }
                case (7):
                    {
                        Console.WriteLine();
                        Console.WriteLine("Конец");
                        Console.WriteLine();
                        break;

                    }
                case (8):
                    {
                        Console.WriteLine("Введите наименование вершины");
                        Console.WriteLine(Console_GraphType.GetIshodDegree(graph, Console.ReadLine()));
                        break;
                    
                    }
                case (9):
                    {
                        
                        Console.WriteLine("Введите вершину старт и конец черезх пробел");
                        string[] two = Console.ReadLine().Split(' ');
                        List<string> n = Console_GraphType.CanGetNodeThroughOneNode(graph,two[0], two[1]);
                        foreach (var elem in n)
                        {
                            Console.Write(elem + " ");
                        }
                        Console.WriteLine();

                        break;
                    }
                case (10):
                    {

                      

                        break;
                    }

                case (11):
                    {


                        Console.WriteLine("Enter start top");
                        string start = Console.ReadLine();                       
                        Console.WriteLine("Enter end top");
                        string end = Console.ReadLine();
                        Console.WriteLine("Enter stop tops ");
                        List<string> stop = new List<string>();
                        string[] stp = Console.ReadLine().Split(' ');
                        foreach (var elem in stp)
                        {
                            stop.Add(elem);                        
                        }

                        List<string> res = new List<string>();
                        Console_GraphType.BFS(graph, start, ref res, stop);
                        Console.WriteLine("=====================================");
                        if (res.Contains(end))
                        {
                            foreach (var elem in res)
                            {
                               
                                Console.WriteLine(elem);
                                if (elem == end) break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Way isnt exist");
                        
                        }
                        break;
                    }

                        default:
                    {
                        Console.WriteLine("Введено некорректное действие");
                        Console.WriteLine();
                        break;
                    }
            }
        }
    }
}


  
