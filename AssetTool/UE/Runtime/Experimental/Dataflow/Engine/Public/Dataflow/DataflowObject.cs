namespace AssetTool
{
    [JsonAsset("Dataflow")]
    public class UDataflow : UEdGraph
    {
        public FGraph Dataflow;

        [Location("void UDataflow::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);//3028
            transfer.Move(ref Dataflow);
            return this;
        }
    }
}