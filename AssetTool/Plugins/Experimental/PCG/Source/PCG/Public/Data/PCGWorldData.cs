namespace AssetTool
{
    [JsonAsset("PCGWorldVolumetricData")]
    public class UPCGWorldVolumetricData : UPCGVolumeData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGWorldRayHitData")]
    public class UPCGWorldRayHitData : UPCGSurfaceData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}