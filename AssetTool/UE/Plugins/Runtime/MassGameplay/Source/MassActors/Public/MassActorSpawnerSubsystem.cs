namespace AssetTool
{
    [JsonAsset("MassActorSpawnerSubsystem")]
    public class UMassActorSpawnerSubsystem : UMassSubsystemBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}