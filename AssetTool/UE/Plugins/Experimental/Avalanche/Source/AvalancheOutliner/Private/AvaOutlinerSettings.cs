namespace AssetTool
{
    [JsonAsset("AvaOutlinerSettings")]
    public class UAvaOutlinerSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}