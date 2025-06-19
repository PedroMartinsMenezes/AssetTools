namespace AssetTool
{
    [JsonAsset("AvaMediaEditorSettings")]
    public class UAvaMediaEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}