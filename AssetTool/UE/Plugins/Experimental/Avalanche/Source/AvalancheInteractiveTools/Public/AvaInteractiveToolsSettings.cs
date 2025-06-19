namespace AssetTool
{
    [JsonAsset("AvaInteractiveToolsSettings")]
    public class UAvaInteractiveToolsSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}