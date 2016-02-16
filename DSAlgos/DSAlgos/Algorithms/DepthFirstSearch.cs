using DSAlgos.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgos.Algorithms
{
    class DepthFirstSearch
    {
        public bool SearchRoute(Graph<string> g, GraphNode<string> start, GraphNode<string> end)
        {
            if (start == end) return true;

            //Set all nodes to unvisited first
            foreach (var node in g.Nodes)
            {
                node.State = NodeState.Unvisited;
            }

            //Start DFS
            foreach (var node in g.Nodes)
            {
                SearchRoute(g, start, end);
                node.State = NodeState.Unvisited;
            }

            return false;
        }

    }
}
