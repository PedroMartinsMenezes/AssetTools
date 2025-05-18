namespace AssetTool
{
    [JsonAsset("AvaOutlinerSettings")]
    public class UAvaOutlinerSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}