namespace AssetTool
{
    [JsonAsset("TextureRenderTargetVolume")]
    public class UTextureRenderTargetVolume : UTextureRenderTarget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}