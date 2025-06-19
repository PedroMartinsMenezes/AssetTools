namespace AssetTool
{
    [JsonAsset("LandscapeScratchRenderTarget")]
    public class ULandscapeScratchRenderTarget : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LandscapeEditResourcesSubsystem")]
    public class ULandscapeEditResourcesSubsystem : UEngineSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}