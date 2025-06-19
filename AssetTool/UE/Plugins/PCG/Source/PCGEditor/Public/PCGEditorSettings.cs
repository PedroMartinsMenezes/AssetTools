namespace AssetTool
{
    [JsonAsset("PCGEditorProjectSettings")]
    public class UPCGEditorProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGEditorSettings")]
    public class UPCGEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}