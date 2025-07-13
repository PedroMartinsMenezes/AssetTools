namespace AssetTool
{
    [JsonAsset("MassReplicationSubsystem")]
    public class UMassReplicationSubsystem : UMassSubsystemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}