namespace AssetTool
{
    [JsonAsset("WebAPIEditorSettings")]
    public class UWebAPIEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}