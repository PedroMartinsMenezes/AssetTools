namespace AssetTool
{
    [JsonAsset("AudioEditorSettings")]
    public class UAudioEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}