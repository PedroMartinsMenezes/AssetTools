namespace AssetTool
{
    [JsonAsset("TextureRenderTargetCube")]
    public class UTextureRenderTargetCube : UTextureRenderTarget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}