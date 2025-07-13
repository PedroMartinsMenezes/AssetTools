namespace AssetTool
{
    [JsonAsset("MassSubsystemBase")]
    public class UMassSubsystemBase : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassTickableSubsystemBase")]
    public class UMassTickableSubsystemBase : UTickableWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}