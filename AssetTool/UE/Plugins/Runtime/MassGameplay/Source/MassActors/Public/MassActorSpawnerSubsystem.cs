namespace AssetTool
{
    [JsonAsset("MassActorSpawnerSubsystem")]
    public class UMassActorSpawnerSubsystem : UMassSubsystemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}