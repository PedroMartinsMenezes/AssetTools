namespace AssetTool
{
    [JsonAsset("WorldMetricInterface")]
    public class UWorldMetricInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}