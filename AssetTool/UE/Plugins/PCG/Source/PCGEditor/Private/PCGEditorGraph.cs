namespace AssetTool
{
    [JsonAsset("PCGEditorGraph")]
    public class UPCGEditorGraph : UEdGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}