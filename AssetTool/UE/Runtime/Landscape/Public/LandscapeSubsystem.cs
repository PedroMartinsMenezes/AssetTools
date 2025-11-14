namespace AssetTool
{
    [JsonAsset("LandscapeSubsystem")]
    public class ULandscapeSubsystem : UTickableWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}