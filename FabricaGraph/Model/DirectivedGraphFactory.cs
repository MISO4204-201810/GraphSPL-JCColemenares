namespace FabricaGraph.Model
{
    public class DirectivedGraphFactory : IGraphFactory
    {
        public WeigthedGraph CreateWeigthedGraph(int size)
        {
            return new DirectivedWeigthedGraph(size);
        }

        public UnweigthedGraph CreateUnweigthedGraph(int size)
        {
            return new DirectivedUnweigthedGraph(size);
        }
    }
}
