namespace AssetTool
{
    public class FGraph : ITransferible
    {
        public FGuid Guid;
        public List<FDataflowNode> Nodes;
        public List<FLink> LocalConnections;

        [Location("void FGraph::SerializeForLoading(FArchive& Ar, FGraph* InGraph, UObject* OwningObject)")]
        public ITransferible Move2(Transfer transfer)
        {
            #region void FGraph::Serialize(FArchive& Ar, UObject* OwningObject)
            transfer.Move(ref Guid);
            #endregion

            #region [Location("Line 282")]
            transfer.Move(ref Nodes);
            #endregion

            transfer.Move(ref LocalConnections);
            return this;
        }
    }

    public class FLink : ITransferible
    {
        public FGuid InputNode;
        public FGuid Input;
        public FGuid OutputNode;
        public FGuid Output;
        public List<FDataflowConnection> Connections;

        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref InputNode);
            transfer.Move(ref OutputNode);
            transfer.Move(ref Input);
            transfer.Move(ref Output);
            return this;
        }
    }
}