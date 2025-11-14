namespace AssetTool
{
    [JsonAsset("AvaEditorSettings")]
    public class UAvaEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}