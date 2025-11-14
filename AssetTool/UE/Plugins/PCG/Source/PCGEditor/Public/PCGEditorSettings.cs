namespace AssetTool
{
    [JsonAsset("PCGEditorProjectSettings")]
    public class UPCGEditorProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGEditorSettings")]
    public class UPCGEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}