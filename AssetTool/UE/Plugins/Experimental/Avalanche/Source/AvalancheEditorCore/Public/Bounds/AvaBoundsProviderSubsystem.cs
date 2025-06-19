namespace AssetTool
{
    [JsonAsset("AvaBoundsProviderSubsystem")]
    public class UAvaBoundsProviderSubsystem : UTickableWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}