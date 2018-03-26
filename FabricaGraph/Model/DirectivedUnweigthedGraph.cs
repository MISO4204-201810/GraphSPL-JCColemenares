using System;

namespace FabricaGraph.Model
{
    public class DirectivedUnweigthedGraph : UnweigthedGraph
    {
        public DirectivedUnweigthedGraph(int size) : base(size) { }

        public override void AddEdge(string source, string destiny)
        {
            base.AddConcreteEdge(source, destiny);
        }

        public override void AddEdge(string source, string destiny, int weigth)
        {
            throw new NotImplementedException("It doesn't needs specify weigth.");
        }
    }
}
