namespace AssetTool
{
    [JsonAsset("TextureRenderTargetVolume")]
    public class UTextureRenderTargetVolume : UTextureRenderTarget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}