namespace AssetTool
{
    [JsonAsset("AvaInteractiveToolsSettings")]
    public class UAvaInteractiveToolsSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}