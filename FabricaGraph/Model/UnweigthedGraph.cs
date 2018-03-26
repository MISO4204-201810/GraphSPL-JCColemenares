using System;
using System.Collections.Generic;

namespace FabricaGraph.Model
{
    public abstract class UnweigthedGraph : Graph
    {
        public UnweigthedGraph(int size) : base(size)
        {
            base.Edges = new List<Edge>(base.EdgeNumber);
        }

        public override void PrintEdges()
        {
            base.ValidatePrintEdges();
            foreach (Edge edge in base.Edges)
                Console.WriteLine(edge);
        }
    }
}
