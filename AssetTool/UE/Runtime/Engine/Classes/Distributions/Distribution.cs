namespace AssetTool
{
    [JsonAsset("Distribution")]
    public class UDistribution : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}