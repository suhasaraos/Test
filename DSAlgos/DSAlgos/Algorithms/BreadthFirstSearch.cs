using DSAlgos.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgos.Algorithms
{
    public class BreadthFirstSearch
    {
        public bool SearchRoute(Graph<string> g, GraphNode<string> start, GraphNode<string> end)
        {
            if (start == end) return true;

            Queue<GraphNode<string>> visitingQueue = new Queue<GraphNode<string>>();

            foreach (var node in g.Nodes)
            {
                node.State = NodeState.Unvisited;
            }

            visitingQueue.Enqueue(start);

            GraphNode<string> currentNode;

            while (visitingQueue.Count > 0)
            {
                currentNode = visitingQueue.Dequeue();

                if (currentNode != null)
                {
                    foreach (var node in currentNode.Children)
                    {
                        if (node.State == NodeState.Unvisited)
                        {
                            if (node == end)
                                return true;
                            else
                            {
                                visitingQueue.Enqueue(node);
                            }
                        }
                    }
                }
                currentNode.State = NodeState.Visited;
            }
            return false;
        }
    }
}
