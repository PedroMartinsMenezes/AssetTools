namespace AssetTool
{
    [JsonAsset("PCGRenderTargetData")]
    public class UPCGRenderTargetData : UPCGBaseTextureData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}