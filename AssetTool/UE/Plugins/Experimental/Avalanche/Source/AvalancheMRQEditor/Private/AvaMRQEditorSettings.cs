namespace AssetTool
{
    [JsonAsset("AvaMRQEditorSettings")]
    public class UAvaMRQEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}