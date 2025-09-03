
namespace AssetTool
{
    public class FGraph : ITransferible
    {
        public FGuid Guid;
        public List<FDataflowNode> Nodes;
        public List<FLink> LocalConnections;

        [Location("void FGraph::Serialize(FArchive& Ar, UObject* OwningObject)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Guid);
            SerializeForLoading(transfer);
            return this;
        }

        [Location("for (int32 Ndx = ArNum; Ndx > 0; Ndx--)")]
        private void SerializeForLoading(Transfer transfer)
        {
            #region for (int32 Ndx = ArNum; Ndx > 0; Ndx--)
            transfer.Move(ref Nodes);
            #endregion

            #region for (const FLink& Con : LocalConnections)
            transfer.Move(ref LocalConnections);
            #endregion
        }
    }

    public class FLink : ITransferible
    {
        public FGuid InputNode;
        public FGuid Input;
        public FGuid OutputNode;
        public FGuid Output;
        public List<FDataflowConnection> Connections;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref InputNode);
            transfer.Move(ref OutputNode);
            transfer.Move(ref Input);
            transfer.Move(ref Output);
            return this;
        }
    }
}