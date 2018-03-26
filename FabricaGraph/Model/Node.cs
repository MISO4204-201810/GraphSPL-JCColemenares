﻿namespace FabricaGraph.Model
{
    public class Node
    {
        public string Name { get; set; }

        public Node(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
