namespace AssetTool
{
    [JsonAsset("StateTreeEditorSettings")]
    public class UStateTreeEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}