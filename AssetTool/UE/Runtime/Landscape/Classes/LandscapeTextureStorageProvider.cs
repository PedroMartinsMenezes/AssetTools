namespace AssetTool
{
    [JsonAsset("LandscapeTextureStorageProviderFactory")]
    public class ULandscapeTextureStorageProviderFactory : UTextureAllMipDataProviderFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}