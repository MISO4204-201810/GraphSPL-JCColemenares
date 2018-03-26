using System;

namespace FabricaGraph.Model
{
    public class WithoutSearchGraph : SearchGraph
    {
        public WithoutSearchGraph(Graph graph) : base(graph) { }

        public override void Search()
        {
            throw new NotImplementedException("The search method is invalid.");
        }
    }
}
