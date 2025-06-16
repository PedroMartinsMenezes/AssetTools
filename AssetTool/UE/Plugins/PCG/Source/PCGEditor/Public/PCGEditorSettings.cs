namespace AssetTool
{
    [JsonAsset("PCGEditorProjectSettings")]
    public class UPCGEditorProjectSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGEditorSettings")]
    public class UPCGEditorSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}