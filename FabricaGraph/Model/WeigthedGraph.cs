using System;
using System.Collections.Generic;

namespace FabricaGraph.Model
{
    public abstract class WeigthedGraph : Graph
    {
        public WeigthedGraph(int size) : base(size)
        {
            base.Edges = new List<WeigthedEdge>(base.EdgeNumber);
        }

        public override void PrintEdges()
        {
            base.ValidatePrintEdges();
            foreach (WeigthedEdge edge in base.Edges)
                Console.WriteLine(edge);
        }
    }
}
