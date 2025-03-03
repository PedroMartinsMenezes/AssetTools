namespace AssetTool
{
    [JsonAsset("PCGTransformPointsSettings")]
    public class UPCGTransformPointsSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}