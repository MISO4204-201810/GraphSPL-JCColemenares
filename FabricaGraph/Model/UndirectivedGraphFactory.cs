namespace FabricaGraph.Model
{
    public class UndirectivedGraphFactory : IGraphFactory
    {
        public WeigthedGraph CreateWeigthedGraph(int size)
        {
            return new UndirectivedWeigthedGraph(size);
        }

        public UnweigthedGraph CreateUnweigthedGraph(int size)
        {
            return new UndirectivedUnweigthedGraph(size);
        }
    }
}
