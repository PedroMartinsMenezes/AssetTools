namespace AssetTool
{
    [JsonAsset("GraphEditorSettings")]
    public class UGraphEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}