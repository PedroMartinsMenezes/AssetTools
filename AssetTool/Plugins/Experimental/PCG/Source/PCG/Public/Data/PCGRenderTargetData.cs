namespace AssetTool
{
    [JsonAsset("PCGRenderTargetData")]
    public class UPCGRenderTargetData : UPCGBaseTextureData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}