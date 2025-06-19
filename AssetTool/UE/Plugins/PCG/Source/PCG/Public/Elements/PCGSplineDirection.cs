namespace AssetTool
{
    [JsonAsset("PCGReverseSplineSettings")]
    public class UPCGReverseSplineSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}