namespace AssetTool
{
    [JsonAsset("AvaInteractiveToolsSettings")]
    public class UAvaInteractiveToolsSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}