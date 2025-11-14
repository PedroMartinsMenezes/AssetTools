namespace AssetTool
{
    [JsonAsset("MassReplicationSubsystem")]
    public class UMassReplicationSubsystem : UMassSubsystemBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}