using System;

namespace FabricaGraph.Model
{
    public class UndirectivedUnweigthedGraph : UnweigthedGraph
    {
        public UndirectivedUnweigthedGraph(int size) : base(size) { }

        public override void AddEdge(string source, string destiny)
        {
            base.AddConcreteEdge(source, destiny);
            base.AddConcreteEdge(destiny, source);
        }

        public override void AddEdge(string source, string destiny, int weigth)
        {
            throw new NotImplementedException("It doesn't needs specify weigth.");
        }
    }
}
