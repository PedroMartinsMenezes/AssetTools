namespace AssetTool
{
    [JsonAsset("PCGCreateSplineSettings")]
    public class UPCGCreateSplineSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}