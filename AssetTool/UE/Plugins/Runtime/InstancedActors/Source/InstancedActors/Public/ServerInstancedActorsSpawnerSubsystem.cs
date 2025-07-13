namespace AssetTool
{
    [JsonAsset("ServerInstancedActorsSpawnerSubsystem")]
    public class UServerInstancedActorsSpawnerSubsystem : UMassActorSpawnerSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}