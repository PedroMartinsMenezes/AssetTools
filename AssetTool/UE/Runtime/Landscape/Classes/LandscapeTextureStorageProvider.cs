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

    [JsonAsset("LandscapeTextureMipEdgeOverrideFactory")]
    public class ULandscapeTextureMipEdgeOverrideFactory : UTextureMipDataProviderFactory
    {
        public FObjectPtr Texture;

        [Location("void ULandscapeTextureMipEdgeOverrideFactory::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Texture);
            return this;
        }
    }
}