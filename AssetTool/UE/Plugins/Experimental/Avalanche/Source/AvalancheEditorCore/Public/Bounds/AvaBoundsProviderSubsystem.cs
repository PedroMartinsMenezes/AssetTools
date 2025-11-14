namespace AssetTool
{
    [JsonAsset("AvaBoundsProviderSubsystem")]
    public class UAvaBoundsProviderSubsystem : UTickableWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}