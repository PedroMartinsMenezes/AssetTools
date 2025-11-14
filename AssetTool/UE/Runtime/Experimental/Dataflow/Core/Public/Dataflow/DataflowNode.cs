namespace AssetTool
{
    public class FDataflowNode : ITransferable
    {
        public FGuid Guid;
        public FName Type;
        public FName Name;
        public int64 NodeDataSize;

        #region Node data
        public byte[] NodeBytes;//Workaround
        public List<FDataflowOutput> Outputs;
        public List<FDataflowInput> Inputs;
        #endregion

        public List<FDataflowConnection> Connections;

        [Location("void FGraph::SerializeForLoading(FArchive& Ar, FGraph* InGraph, UObject* OwningObject)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Guid);
            transfer.Move(ref Type);
            transfer.Move(ref Name);

            transfer.Move(ref NodeDataSize);

            transfer.Move(ref NodeBytes, (int)NodeDataSize);

            transfer.Move(ref Connections);

            //if (!transfer.Supports.DataflowSeparateInputOutputSerialization)
            //{
            //    transfer.Move(ref Connections);
            //}
            //else
            //{
            //    transfer.Move(ref Outputs);
            //    transfer.Move(ref Inputs);
            //}
            return this;
        }
    }
}