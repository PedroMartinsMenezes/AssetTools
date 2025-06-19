namespace AssetTool
{
    [JsonAsset("Distribution")]
    public class UDistribution : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}