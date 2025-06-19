namespace AssetTool
{
    [JsonAsset("AvaRundownEditorSettings")]
    public class UAvaRundownEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}