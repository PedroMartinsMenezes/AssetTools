namespace AssetTool
{
    [JsonAsset("MassNavigationSubsystem")]
    public class UMassNavigationSubsystem : UMassSubsystemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}