namespace AssetTool
{
    [JsonAsset("LandscapeScratchRenderTarget")]
    public class ULandscapeScratchRenderTarget : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LandscapeEditResourcesSubsystem")]
    public class ULandscapeEditResourcesSubsystem : UEngineSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}