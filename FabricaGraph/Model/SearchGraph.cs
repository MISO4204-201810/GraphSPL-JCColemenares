using FabricaGraph.Enums;
using FabricaGraph.Utility;

namespace FabricaGraph.Model
{
    public abstract class SearchGraph
    {
        protected Graph Graph { get; set; }

        public abstract void Search();

        public SearchGraph(Graph graph)
        {
            Graph = graph;
        }
    }
}
