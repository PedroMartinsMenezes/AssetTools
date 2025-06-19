namespace AssetTool
{
    [JsonAsset("AvaEditorSettings")]
    public class UAvaEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}