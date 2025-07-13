namespace AssetTool
{
    [JsonAsset("SCSEditorExtensionContext")]
    public class USCSEditorExtensionContext : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}