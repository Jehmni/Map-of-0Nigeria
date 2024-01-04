using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace stringGraph
{
    public class Graph
    {
        int numOfEdges;
        // A list that will hold the nodes in the graph
        private LinkedList<GraphNode> nodes;

        // Constructor to set the list of nodes to an empty list
        public Graph()
        {
            nodes = new LinkedList<GraphNode>();
        }

        // Adds a new node to the graph with the specified ID
        public void AddNode(String id)
        {
            nodes.AddLast(new GraphNode(id));
        }

        // Returns the node with the specified ID
        public GraphNode GetNode(String id)
        {
            foreach (GraphNode node in nodes)
            {
                if (id.CompareTo(node.ID) == 0)
                    return node;
            }

            return null;
        }

        // Adds a directed edge between two nodes specified by their IDs
        public void AddEdge(string from, string to)
        {
            // Get the GraphNode that corresponds to the node with ID "from"
            GraphNode node1 = GetNode(from);

            // Get the GraphNode that corresponds to the node with ID "to"
            GraphNode node2 = GetNode(to);

            // Add a directed edge from node1 to node2
            node1.AddEdge(node2);

            numOfEdges++;
        }

        // Checks if the graph is empty (has no nodes)
        public bool IsEmptyGraph()
        {
            // Returns true if the number of nodes in the list is 0, false otherwise
            return nodes.Count == 0;
        }

        // Returns the total number of nodes in the graph
        public int NumberOfNodes()
        {
            return nodes.Count;
        }

        // Returns the total number of edges present in the graph
        public int NumEdgesGraph()
        {
            return numOfEdges;
        }

        // Displays the IDs of nodes adjacent to the node with the specified ID
        public void DisplayAdjNodes(string inputID)
        {
            // Define a list to store the adjacency list of the node
            LinkedList<string> adjl = new LinkedList<string>();

            // Get the GraphNode of the node with the specified ID
            GraphNode n = GetNode(inputID);

            // Get the adjacency list of node n and store it in adjl
            adjl = n.GetAdjList();

            // Display the IDs of all nodes in adjl
            foreach (string id in adjl)
            {
                Console.WriteLine(id);
            }
        }

        // Checks if the graph contains a node with the specified ID
        public bool ContainsGraph(string ID)
        {
            foreach (GraphNode n in nodes)
            {
                // Check if the ID of the current node is equal to the specified ID
                if (n.ID.CompareTo(ID) == 0)
                    return true;
            }

            // Node with the specified ID was not found, so return false
            return false;
        }
    }
}
