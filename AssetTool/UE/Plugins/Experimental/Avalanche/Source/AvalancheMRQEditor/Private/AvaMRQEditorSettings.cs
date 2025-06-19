namespace AssetTool
{
    [JsonAsset("AvaMRQEditorSettings")]
    public class UAvaMRQEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}