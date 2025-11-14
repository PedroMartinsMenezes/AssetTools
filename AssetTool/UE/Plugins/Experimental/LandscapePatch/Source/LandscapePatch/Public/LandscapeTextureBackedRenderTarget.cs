namespace AssetTool
{
    [JsonAsset("LandscapeTextureBackedRenderTargetBase")]
    public class ULandscapeTextureBackedRenderTargetBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LandscapeWeightTextureBackedRenderTarget")]
    public class ULandscapeWeightTextureBackedRenderTarget : ULandscapeTextureBackedRenderTargetBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LandscapeHeightTextureBackedRenderTarget")]
    public class ULandscapeHeightTextureBackedRenderTarget : ULandscapeTextureBackedRenderTargetBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}