namespace FabricaGraph.Model
{
    public interface IGraphFactory
    {
        WeigthedGraph CreateWeigthedGraph(int size);

        UnweigthedGraph CreateUnweigthedGraph(int size);
    }
}
