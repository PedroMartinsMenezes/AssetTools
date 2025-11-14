namespace AssetTool
{
    [JsonAsset("VirtualScoutingSettings")]
    public class UVirtualScoutingSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VirtualScoutingEditorSettings")]
    public class UVirtualScoutingEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}