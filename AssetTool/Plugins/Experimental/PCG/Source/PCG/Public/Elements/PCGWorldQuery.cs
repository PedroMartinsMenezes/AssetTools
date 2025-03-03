namespace AssetTool
{
    [JsonAsset("PCGWorldQuerySettings")]
    public class UPCGWorldQuerySettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGWorldRayHitSettings")]
    public class UPCGWorldRayHitSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}