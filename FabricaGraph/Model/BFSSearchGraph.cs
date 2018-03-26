using System;

namespace FabricaGraph.Model
{
    public class BFSSearchGraph : SearchGraph
    {
        public BFSSearchGraph(Graph graph) : base(graph) { }

        public override void Search()
        {
            Console.WriteLine("BFS Algorithm");
        }
    }
}
