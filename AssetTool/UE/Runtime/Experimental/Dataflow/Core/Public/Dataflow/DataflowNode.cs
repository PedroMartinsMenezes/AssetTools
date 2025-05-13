namespace AssetTool
{
    public class FDataflowNode : ITransferible
    {
        public FGuid Guid;
        public FName Type;
        public FName Name;
        public int64 NodeDataSize;
        public UScriptStruct Struct;
        public List<FDataflowConnection> Connections;
        public List<FDataflowOutput> Outputs;
        public List<FDataflowInput> Inputs;

        [Location("void FGraph::SerializeForLoading(FArchive& Ar, FGraph* InGraph, UObject* OwningObject) line 282")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Guid);
            transfer.Move(ref Type);
            transfer.Move(ref Name);
            transfer.Move(ref NodeDataSize);
            if (!transfer.Supports.DataflowSeparateInputOutputSerialization)
            {
                transfer.Move(ref Connections);
            }
            else
            {
                Struct ??= new();
                Struct.SerializeTaggedProperties(transfer); //3172
                //Node->SerializeInternal(Ar); 3172
                //SerializeTaggedProperties

                transfer.Move(ref Outputs);
                transfer.Move(ref Inputs);
            }
            return this;
        }
    }
}