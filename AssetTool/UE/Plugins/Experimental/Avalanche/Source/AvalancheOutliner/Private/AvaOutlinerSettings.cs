namespace AssetTool
{
    [JsonAsset("AvaOutlinerSettings")]
    public class UAvaOutlinerSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}