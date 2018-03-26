using System;
using System.Collections.Generic;
using System.Linq;

namespace FabricaGraph.Model
{
    public abstract class Graph
    {
        #region Public Properties

        public int Size { get; set; }
        public List<Node> Nodes { get; set; }
        public IEnumerable<Edge> Edges { get; set; }

        #endregion Public Properties

        #region Protected Properties

        protected int EdgeNumber { get; set; }

        #endregion Protected Properties

        #region Constructor

        public Graph(int size)
        {
            if (size < 2)
                throw new Exception("The size must be equal or higher than 2.");
            Size = size;
            EdgeNumber = (size * size) - size;
            Nodes = new List<Node>(size);
        }

        #endregion Constructor

        #region Public Abstract Methods

        public abstract void AddEdge(string source, string destiny);

        public abstract void AddEdge(string source, string destiny, int weigth);

        public abstract void PrintEdges();

        #endregion Public Abstract Methods

        #region Public Methods

        public void AddNode(string name)
        {
            if (Nodes.Exists(x => x.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase)))
                throw new Exception("The name exists in the graph list.");
            Nodes.Add(new Node(name));
        }

        public void PrintNodes()
        {
            if (!Nodes.Any())
                throw new Exception("There's no nodes.");
            int index = 0;
            foreach (Node node in Nodes)
                Console.WriteLine(String.Format("Node {0}: {1}", ++index, node));
        }

        #endregion Public Methods

        #region Protected Methods

        protected void AddConcreteEdge(string source, string destiny)
        {
            Tuple<Node, Node> edge = BuildEdgeNodes(source, destiny);
            Edges = Edges.Append(new Edge(source: edge.Item1,
                                        destiny: edge.Item2));
        }

        protected void AddConcreteEdge(string source, string destiny, int weigth)
        {
            Tuple<Node, Node> edge = BuildEdgeNodes(source, destiny);
            Edges = Edges.Append(new WeigthedEdge(source: edge.Item1,
                                                destiny: edge.Item2,
                                                weigth: weigth));
        }

        protected void ValidatePrintEdges()
        {
            if (!Edges.Any())
                throw new Exception("There's no edges.");
        }

        #endregion Protected Methods

        #region Private Methods

        private Tuple<Node, Node> BuildEdgeNodes(string source, string destiny)
        {
            Node nodeSource = Nodes.FirstOrDefault(x => x.Name.Equals(source, StringComparison.InvariantCultureIgnoreCase));
            Node nodeDestiny = Nodes.FirstOrDefault(x => x.Name.Equals(destiny, StringComparison.InvariantCultureIgnoreCase));
            if (nodeSource == null)
                throw new Exception("The source node doesn't exists.");
            if (nodeDestiny == null)
                throw new Exception("The destiny node doesn't exists.");
            if (Edges.ToList().Exists(x => x.Source.Equals(nodeSource)
                                        && x.Destiny.Equals(nodeDestiny)))
                throw new Exception("The edge already exists.");
            return new Tuple<Node, Node>(nodeSource, nodeDestiny);
        }

        #endregion Private Methods
    }
}
