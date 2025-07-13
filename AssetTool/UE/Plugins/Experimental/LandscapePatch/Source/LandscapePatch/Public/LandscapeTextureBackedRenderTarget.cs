namespace AssetTool
{
    [JsonAsset("LandscapeTextureBackedRenderTargetBase")]
    public class ULandscapeTextureBackedRenderTargetBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LandscapeWeightTextureBackedRenderTarget")]
    public class ULandscapeWeightTextureBackedRenderTarget : ULandscapeTextureBackedRenderTargetBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LandscapeHeightTextureBackedRenderTarget")]
    public class ULandscapeHeightTextureBackedRenderTarget : ULandscapeTextureBackedRenderTargetBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}