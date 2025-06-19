namespace AssetTool
{
    [JsonAsset("PCGTransformPointsSettings")]
    public class UPCGTransformPointsSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}