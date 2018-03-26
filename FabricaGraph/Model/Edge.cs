using System;

namespace FabricaGraph.Model
{
    public class Edge
    {
        public Node Source { get; set; }
        public Node Destiny { get; set; }

        public Edge(Node source, Node destiny)
        {
            Source = source;
            Destiny = destiny;
        }

        public override string ToString()
        {
            return String.Format("Source name: {0}. Destiny name: {1}.", Source, Destiny);
        }
    }
}
