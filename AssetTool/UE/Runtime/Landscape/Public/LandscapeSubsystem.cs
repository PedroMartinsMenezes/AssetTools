namespace AssetTool
{
    [JsonAsset("LandscapeSubsystem")]
    public class ULandscapeSubsystem : UTickableWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}