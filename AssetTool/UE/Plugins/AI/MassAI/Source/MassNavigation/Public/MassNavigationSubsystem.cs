namespace AssetTool
{
    [JsonAsset("MassNavigationSubsystem")]
    public class UMassNavigationSubsystem : UMassSubsystemBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}