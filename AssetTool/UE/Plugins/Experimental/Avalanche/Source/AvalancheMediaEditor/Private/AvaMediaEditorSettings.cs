namespace AssetTool
{
    [JsonAsset("AvaMediaEditorSettings")]
    public class UAvaMediaEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}