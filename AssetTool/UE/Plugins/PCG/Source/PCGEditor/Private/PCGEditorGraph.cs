namespace AssetTool
{
    [JsonAsset("PCGEditorGraph")]
    public class UPCGEditorGraph : UEdGraph
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}