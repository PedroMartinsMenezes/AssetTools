namespace AssetTool
{
    [JsonAsset("PCGEditorGraph")]
    public class UPCGEditorGraph : UEdGraph
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}