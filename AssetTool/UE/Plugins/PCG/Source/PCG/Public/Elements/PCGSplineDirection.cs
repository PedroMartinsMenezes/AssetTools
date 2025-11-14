namespace AssetTool
{
    [JsonAsset("PCGReverseSplineSettings")]
    public class UPCGReverseSplineSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}