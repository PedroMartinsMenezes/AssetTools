namespace AssetTool
{
    public class FGraph : ITransferible
    {
        public FGuid Guid;
        public List<FDataflowNode> Nodes;
        public List<FLink> LocalConnections;
        public int32 ArNum;

        [Location("void FGraph::Serialize(FArchive& Ar, UObject* OwningObject)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Guid);
            SerializeForLoading(transfer);
            return this;
        }

        [Location("void FGraph::SerializeForLoading(FArchive& Ar, FGraph* InGraph, UObject* OwningObject)")]
        private void SerializeForLoading(Transfer transfer)
        {
            transfer.Move(ref ArNum);
            transfer.Resize(ref Nodes, ArNum);
            for (int32 Ndx = 0; Ndx < ArNum; Ndx++)
            {
                FDataflowNode node = Nodes[Ndx];

                transfer.Move(ref node.Guid);
                transfer.Move(ref node.Type);
                transfer.Move(ref node.Name);

                FDataflowNode node2 = NewNodeFromRegisteredType();

                if (DATAFLOW_OPTIONAL_BLOCK_READ_BEGIN(transfer, node, node2 != null))
                {
                    throw new NotImplementedException();
                }
                else
                {
                    DATAFLOW_OPTIONAL_BLOCK_READ_ELSE(transfer, node);
                }
            }

            transfer.Move(ref LocalConnections);
        }

        private static FDataflowNode NewNodeFromRegisteredType()
        {
            return null;
        }

        private static bool DATAFLOW_OPTIONAL_BLOCK_READ_BEGIN(Transfer transfer, FDataflowNode node, bool condition)
        {
            transfer.Move(ref node.NodeDataSize);
            return condition;
        }

        private static void DATAFLOW_OPTIONAL_BLOCK_READ_ELSE(Transfer transfer, FDataflowNode node)
        {
            transfer.Move(ref node.NodeBytes, (int)node.NodeDataSize);
        }
    }

    public class FLink : ITransferible
    {
        public FGuid InputNode;
        public FGuid Input;
        public FGuid OutputNode;
        public FGuid Output;

        [Location("FArchive& operator<<(FArchive& Ar, UE::Dataflow::FLink& Value)")]
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