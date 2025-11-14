namespace AssetTool
{
    [JsonAsset("Dataflow")]
    public class UDataflow : UEdGraph
    {
        public FGraph Dataflow;

        [Location("void UDataflow::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Dataflow);
            return this;
        }
    }
}