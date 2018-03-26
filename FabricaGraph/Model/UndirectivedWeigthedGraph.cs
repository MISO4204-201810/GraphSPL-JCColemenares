using System;

namespace FabricaGraph.Model
{
    public class UndirectivedWeigthedGraph : WeigthedGraph
    {
        public UndirectivedWeigthedGraph(int size) : base(size) { }

        public override void AddEdge(string source, string destiny)
        {
            throw new NotImplementedException("It needs specify weigth.");
        }

        public override void AddEdge(string source, string destiny, int weigth)
        {
            base.AddConcreteEdge(source, destiny, weigth);
            base.AddConcreteEdge(destiny, source, weigth);
        }
    }
}
