namespace AssetTool
{
    [JsonAsset("OutlinerSettings")]
    public class UOutlinerSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}