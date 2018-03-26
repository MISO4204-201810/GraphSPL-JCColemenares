using System;

namespace FabricaGraph.Model
{
    public class WeigthedEdge : Edge
    {
        public int Weight { get; set; }

        public WeigthedEdge(Node source, Node destiny, int weigth) : base(source, destiny)
        {
            Weight = weigth;
        }

        public override string ToString()
        {
            return String.Format("Source name: {0}. Destiny name: {1}. Weigth: {2}.", Source, Destiny, Weight);
        }
    }
}
