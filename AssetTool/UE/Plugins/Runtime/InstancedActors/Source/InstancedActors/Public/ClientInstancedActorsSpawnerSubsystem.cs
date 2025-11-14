namespace AssetTool
{
    [JsonAsset("ClientInstancedActorsSpawnerSubsystem")]
    public class UClientInstancedActorsSpawnerSubsystem : UMassActorSpawnerSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}