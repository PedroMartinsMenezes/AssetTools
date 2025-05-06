namespace AssetTool
{
    [JsonAsset("LandscapeScratchRenderTarget")]
    public class ULandscapeScratchRenderTarget : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LandscapeEditResourcesSubsystem")]
    public class ULandscapeEditResourcesSubsystem : UEngineSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}