namespace AssetTool
{
    [JsonAsset("MassStateTreeSubsystem")]
    public class UMassStateTreeSubsystem : UMassSubsystemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}