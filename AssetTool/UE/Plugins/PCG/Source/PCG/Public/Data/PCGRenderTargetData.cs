namespace AssetTool
{
    [JsonAsset("PCGRenderTargetData")]
    public class UPCGRenderTargetData : UPCGBaseTextureData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}