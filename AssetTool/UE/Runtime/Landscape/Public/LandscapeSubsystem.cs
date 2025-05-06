namespace AssetTool
{
    [JsonAsset("LandscapeSubsystem")]
    public class ULandscapeSubsystem : UTickableWorldSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}