namespace AssetTool
{
    [JsonAsset("AudioEditorSettings")]
    public class UAudioEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}