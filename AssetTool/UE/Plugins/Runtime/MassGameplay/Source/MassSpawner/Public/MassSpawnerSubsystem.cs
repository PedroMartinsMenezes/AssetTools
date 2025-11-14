namespace AssetTool
{
    [JsonAsset("MassSpawnerSubsystem")]
    public class UMassSpawnerSubsystem : UMassSubsystemBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}