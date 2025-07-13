namespace AssetTool
{
    [JsonAsset("WebAPIEditorSettings")]
    public class UWebAPIEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}