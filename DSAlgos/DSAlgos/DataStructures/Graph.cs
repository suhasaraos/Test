﻿using DSAlgos.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgos.DataStructures
{
    public class GraphDemo
    {
        public void Run()
        {
            Graph<string> graph = new Graph<string>();

            var bfs = new BreadthFirstSearch();
            var dfs = new DepthFirstSearch();

            graph.Nodes = new GraphNode<string>[4];

            var a = new GraphNode<string>("a");
            var b = new GraphNode<string>("b");
            var c = new GraphNode<string>("c");
            var d = new GraphNode<string>("d");
            

            a.Children = new[] { b };
            graph.Nodes[0] = a;
           
            b.Children = new[] { c};
            graph.Nodes[1] = b;

            c.Children = new[] { a };
            graph.Nodes[2] = c;

            d.Children = new[] { b, c };
            graph.Nodes[3] = d;

            PrintAdjacencyList(graph);          

            //Console.WriteLine("Is there a route from a to d: " + bfs.SearchRoute(graph, a, d));

            //Console.WriteLine("Is there a route from d to a: " + bfs.SearchRoute(graph, d, a));

            //Console.WriteLine("Is there a route from a to d: " + dfs.SearchRoute(a, d));

            //Console.WriteLine("Is there a route from d to a: " + dfs.SearchRoute(d, a));

        }        

        void PrintAdjacencyList(Graph<string> g)
        {
            Console.WriteLine("Adjacency List");
            foreach (var node in g.Nodes)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(node.Value + ": {");
                foreach(var child in node.Children)
                {
                    sb.Append(child.Value + ", ");
                }
                sb.Append("}");

                Console.WriteLine(sb.ToString());
            }
        }        
    }

    public class Graph<T>
    {
        public GraphNode<T>[] Nodes { get; set; }
    }

    public enum NodeState { Unvisited, Visited }
    public class GraphNode<T>
    {
        public GraphNode(T data)
        {
            this.Value = data;
        }
        public T Value { private set; get; }
        public GraphNode<T>[] Children { get; set; }

        public NodeState State { get; set; }
    }



}
