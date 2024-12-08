namespace AssetTool
{
    [JsonAsset("TextureRenderTargetVolume")]
    public class UTextureRenderTargetVolume : UTextureRenderTarget
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}