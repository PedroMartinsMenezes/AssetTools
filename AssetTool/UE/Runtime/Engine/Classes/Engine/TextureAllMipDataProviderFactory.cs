namespace AssetTool
{
    [JsonAsset("TextureAllMipDataProviderFactory")]
    public class UTextureAllMipDataProviderFactory : UTextureMipDataProviderFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}