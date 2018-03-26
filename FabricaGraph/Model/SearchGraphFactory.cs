using FabricaGraph.Utility;
using System;

namespace FabricaGraph.Model
{
    public class SearchGraphFactory
    {
        public Graph Graph { get; set; }

        public SearchGraphFactory(Graph graph)
        {
            Graph = graph;
        }

        public SearchGraph GetSearchGraphInstance()
        {
            string nameSearchGraph = String.Format("FabricaGraph.Model.{0}SearchGraph", Configuration.ConfiguracionGlobal.TypeSearch.ToString());
            return (SearchGraph)Activator.CreateInstance(Type.GetType(nameSearchGraph), Graph);
        }
    }
}
