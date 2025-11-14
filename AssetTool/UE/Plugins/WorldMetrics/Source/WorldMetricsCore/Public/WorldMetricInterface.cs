namespace AssetTool
{
    [JsonAsset("WorldMetricInterface")]
    public class UWorldMetricInterface : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}