using FabricaGraph.Enums;
using FabricaGraph.Model;
using FabricaGraph.Utility;
using System;
using System.Reflection;

namespace FabricaGraph
{
    public class Program
    {
        #region Private Properties

        private static Graph Graph { get; set; }

        #endregion Private Properties

        #region Main

        public static void Main(string[] args)
        {
            Console.WriteLine("Fabrica de grafos");
            SelectOption();
        }

        #endregion Main

        #region Private Methods

        private static void SelectOption()
        {
            sbyte option;
            while (true)
            {
                Console.WriteLine("Ingresa una opcion");
                Console.WriteLine("----------------------");
                Console.WriteLine("1. Crear grafo");
                Console.WriteLine("2. Adicionar relacion");
                Console.WriteLine("3. Imprimir nodos");
                Console.WriteLine("4. Imprimir relaciones");
                Console.WriteLine("5. Realizar busqueda");
                Console.WriteLine("6. Salir");
                Console.WriteLine("----------------------");
                try
                {
                    option = Convert.ToSByte(Console.ReadLine());
                    if (option == 6) return;
                    switch (option)
                    {
                        case 1:
                            CreateGraph();
                            break;
                        case 2:
                            AddEdge();
                            break;
                        case 3:
                            PrintNodes();
                            break;
                        case 4:
                            PrintEdges();
                            break;
                        case 5:
                            Search();
                            break;
                        default:
                            Console.WriteLine("Opcion invalida");
                            break;
                    }
                    Console.WriteLine("----------------------");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(String.Format("Ocurrio el siguiente error en la aplicacion: {0}", ex.Message));
                    Console.WriteLine("----------------------");
                }
            }
        }

        private static void CreateGraph()
        {
            Console.WriteLine("Ingresa el numero de nodos");
            byte nodesNumber = Convert.ToByte(Console.ReadLine());
            Graph = CreateInstanceGraph(nodesNumber);
            Console.WriteLine("----------------------");
            for (int i = 0; i < nodesNumber; i++)
            {
                Console.WriteLine("Ingresa un nodo");
                Graph.AddNode(Console.ReadLine());
                Console.WriteLine("Nodo adicionado.");
                Console.WriteLine("----------------------");
            }
            Console.WriteLine("Grafo creado.");
        }

        private static Graph CreateInstanceGraph(int nodesNumber)
        {
            string nameGraphFactory = String.Format("FabricaGraph.Model.{0}GraphFactory", Configuration.ConfiguracionGlobal.TypeDirectivity.ToString());
            Type graphFactoryType = Type.GetType(nameGraphFactory);
            IGraphFactory factory = (IGraphFactory)Activator.CreateInstance(graphFactoryType);
            string nameGraphFactoryMethod = String.Format("Create{0}Graph", Configuration.ConfiguracionGlobal.TypeWeigthed.ToString());
            MethodInfo method = graphFactoryType.GetMethod(nameGraphFactoryMethod);
            return (Graph)method.Invoke(factory, new object[] { nodesNumber });

        }

        private static void AddEdge()
        {
            Console.WriteLine("Ingresa la relacion entre dos nodos");
            Console.WriteLine("Ingresa el nodo origen");
            string sourceNodeName = Console.ReadLine();
            Console.WriteLine("Ingresa el nodo destino");
            string destinyNodeName = Console.ReadLine();
            int? nodeWeigth = null;
            if (Configuration.ConfiguracionGlobal.TypeWeigthed == TypeWeigthed.Weigthed)
            {
                Console.WriteLine("Ingresa el peso de la relacion");
                nodeWeigth = Convert.ToInt32(Console.ReadLine());
            }
            if (nodeWeigth.HasValue)
                Graph.AddEdge(source: sourceNodeName,
                                destiny: destinyNodeName,
                                weigth: nodeWeigth.Value);
            else
                Graph.AddEdge(sourceNodeName, destinyNodeName);
            Console.WriteLine("Relacion adicionada.");
        }

        private static void PrintNodes()
        {
            Graph.PrintNodes();
        }

        private static void PrintEdges()
        {
            Graph.PrintEdges();
        }

        private static void Search()
        {
            new SearchGraphFactory(Graph).GetSearchGraphInstance().Search();
        }

        #endregion Private Methods
    }
}
