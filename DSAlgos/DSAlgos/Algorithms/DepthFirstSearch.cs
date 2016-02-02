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
        bool SearchDFS(Graph<string> g, GraphNode<string> start, GraphNode<string> end)
        {
            if (start == end) return true;

            foreach (var node in g.Nodes)
            {
                node.State = NodeState.Unvisited;
            }

            return false;
            //foreach (var node in g.Nodes)
            //{
            //    node.State = NodeState.Unvisited;
            //}

          

         
            
        }

    }
}
