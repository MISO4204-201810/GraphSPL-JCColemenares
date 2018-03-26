using System;

namespace FabricaGraph.Model
{
    public class DirectivedWeigthedGraph : WeigthedGraph
    {
        public DirectivedWeigthedGraph(int size) : base(size) { }

        public override void AddEdge(string source, string destiny)
        {
            throw new NotImplementedException("It needs specify weigth.");
        }

        public override void AddEdge(string source, string destiny, int weigth)
        {
            base.AddConcreteEdge(source, destiny, weigth);
        }
    }
}
