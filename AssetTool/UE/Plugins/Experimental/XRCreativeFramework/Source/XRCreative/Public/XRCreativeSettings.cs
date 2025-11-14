namespace AssetTool
{
    [JsonAsset("XRCreativeSettings")]
    public class UXRCreativeSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("XRCreativeEditorSettings")]
    public class UXRCreativeEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}