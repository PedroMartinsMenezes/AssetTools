namespace AssetTool
{
    [JsonAsset("PCGVirtualTextureData")]
    public class UPCGVirtualTextureData : UPCGSurfaceData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}