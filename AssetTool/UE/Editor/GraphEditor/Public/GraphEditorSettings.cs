namespace AssetTool
{
    [JsonAsset("GraphEditorSettings")]
    public class UGraphEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}