namespace AssetTool
{
    [JsonAsset("PCGVirtualTextureData")]
    public class UPCGVirtualTextureData : UPCGSurfaceData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}