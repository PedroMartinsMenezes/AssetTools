namespace AssetTool
{
    [JsonAsset("HistogramSettings")]
    public class UHistogramSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}