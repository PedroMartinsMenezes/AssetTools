namespace AssetTool
{
    [JsonAsset("AvaTransitionEditorSettings")]
    public class UAvaTransitionEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}