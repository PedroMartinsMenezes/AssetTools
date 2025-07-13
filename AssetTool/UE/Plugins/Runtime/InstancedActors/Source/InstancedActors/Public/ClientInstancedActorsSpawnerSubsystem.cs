namespace AssetTool
{
    [JsonAsset("ClientInstancedActorsSpawnerSubsystem")]
    public class UClientInstancedActorsSpawnerSubsystem : UMassActorSpawnerSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}