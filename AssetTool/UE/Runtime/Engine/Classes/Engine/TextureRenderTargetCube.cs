namespace AssetTool
{
    [JsonAsset("TextureRenderTargetCube")]
    public class UTextureRenderTargetCube : UTextureRenderTarget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}