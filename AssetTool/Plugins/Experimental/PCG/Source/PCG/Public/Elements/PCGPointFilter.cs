namespace AssetTool
{
    [JsonAsset("PCGPointFilterSettings")]
    public class UPCGPointFilterSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGPointFilterRangeSettings")]
    public class UPCGPointFilterRangeSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}