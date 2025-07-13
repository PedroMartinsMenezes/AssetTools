namespace AssetTool
{
    [JsonAsset("MassSpawnerSubsystem")]
    public class UMassSpawnerSubsystem : UMassSubsystemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}