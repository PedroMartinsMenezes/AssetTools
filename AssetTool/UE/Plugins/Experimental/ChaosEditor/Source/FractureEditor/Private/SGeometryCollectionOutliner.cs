namespace AssetTool
{
    [JsonAsset("OutlinerSettings")]
    public class UOutlinerSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}