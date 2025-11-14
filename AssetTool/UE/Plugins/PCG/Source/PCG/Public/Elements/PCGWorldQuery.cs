namespace AssetTool
{
    [JsonAsset("PCGWorldQuerySettings")]
    public class UPCGWorldQuerySettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGWorldRayHitSettings")]
    public class UPCGWorldRayHitSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}