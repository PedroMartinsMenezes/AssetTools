namespace AssetTool
{
    [JsonAsset("EdGraph")]
    public class UEdGraph : UObject
    {
        [Location("void UEdGraph::Serialize(FStructuredArchiveRecord Record)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
