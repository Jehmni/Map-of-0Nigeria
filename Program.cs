using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringGraph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Graph
            Graph nigeria = new Graph();

            // Add nodes in the graph
            nigeria.AddNode("Abia");
            nigeria.AddNode("Adamawa");
            nigeria.AddNode("Akwa Ibom");
            nigeria.AddNode("Anambra");
            nigeria.AddNode("Bauchi");
            nigeria.AddNode("Bayelsa");
            nigeria.AddNode("Benue");
            nigeria.AddNode("Borno");
            nigeria.AddNode("Cross River");
            nigeria.AddNode("Delta");
            nigeria.AddNode("Ebonyi");
            nigeria.AddNode("Edo");
            nigeria.AddNode("Ekiti");
            nigeria.AddNode("Enugu");
            nigeria.AddNode("Gombe");
            nigeria.AddNode("Imo");
            nigeria.AddNode("Jigawa");
            nigeria.AddNode("Kaduna");
            nigeria.AddNode("Kano");
            nigeria.AddNode("Katsina");
            nigeria.AddNode("Kebbi");
            nigeria.AddNode("Kogi");
            nigeria.AddNode("Kwara");
            nigeria.AddNode("Lagos");
            nigeria.AddNode("Nasarawa");
            nigeria.AddNode("Niger");
            nigeria.AddNode("Ogun");
            nigeria.AddNode("Ondo");
            nigeria.AddNode("Osun");
            nigeria.AddNode("Oyo");
            nigeria.AddNode("Plateau");
            nigeria.AddNode("Rivers");
            nigeria.AddNode("Sokoto");
            nigeria.AddNode("Taraba");
            nigeria.AddNode("Yobe");
            nigeria.AddNode("Zamfara");
            nigeria.AddNode("Abuja");

            // Add connections between the nodes. (Directed edges)
            // These connections represent the adjacency between the states in Nigeria
            nigeria.AddEdge("Abia", "Akwa Ibom");
            nigeria.AddEdge("Abia", "Imo");
            nigeria.AddEdge("Adamawa", "Borno");
            nigeria.AddEdge("Adamawa", "Taraba");
            nigeria.AddEdge("Adamawa", "Yobe");
            nigeria.AddEdge("Akwa Ibom", "Cross River");
            nigeria.AddEdge("Akwa Ibom", "Delta");
            nigeria.AddEdge("Anambra", "Delta");
            nigeria.AddEdge("Anambra", "Enugu");
            nigeria.AddEdge("Anambra", "Kogi");
            nigeria.AddEdge("Bauchi", "Gombe");
            nigeria.AddEdge("Bauchi", "Jigawa");
            nigeria.AddEdge("Bauchi", "Kaduna");
            nigeria.AddEdge("Bauchi", "Kano");
            nigeria.AddEdge("Bauchi", "Plateau");
            nigeria.AddEdge("Bayelsa", "Delta");
            nigeria.AddEdge("Bayelsa", "Rivers");
            nigeria.AddEdge("Benue", "Kogi");
            nigeria.AddEdge("Benue", "Nasarawa");
            nigeria.AddEdge("Benue", "Taraba");
            nigeria.AddEdge("Borno", "Yobe");
            nigeria.AddEdge("Cross River", "Ebonyi");
            nigeria.AddEdge("Cross River", "Enugu");
            nigeria.AddEdge("Cross River", "Benue");
            nigeria.AddEdge("Delta", "Edo");
            nigeria.AddEdge("Delta", "Kogi");
            nigeria.AddEdge("Delta", "Ondo");
            nigeria.AddEdge("Delta", "Rivers");
            nigeria.AddEdge("Ebonyi", "Enugu");

            // Test the functionality of the Graph class
            Console.WriteLine("Graph empty? True or False");
            Console.WriteLine(nigeria.IsEmptyGraph());
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("This is to test the Contains method");
            Console.WriteLine("Yes, graph contains state called " + nigeria.GetNode("Akwa Ibom").ID);
            Console.WriteLine("Does graph contain state called 'Abia', True or False?");
            Console.WriteLine(nigeria.ContainsGraph("Abia"));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Display all the states you can get to from 'Bauchi'");
            nigeria.DisplayAdjNodes("Bauchi");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Total Number of states is:" + nigeria.NumberOfNodes());
            Console.WriteLine("Total Number of edges is:" + nigeria.NumEdgesGraph());

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
