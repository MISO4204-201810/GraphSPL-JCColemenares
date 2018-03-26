using System;

namespace FabricaGraph.Model
{
    public class DFSSearchGraph : SearchGraph
    {
        public DFSSearchGraph(Graph graph) : base(graph) { }

        public override void Search()
        {
            Console.WriteLine("DFS Algorithm");
        }
    }
}
