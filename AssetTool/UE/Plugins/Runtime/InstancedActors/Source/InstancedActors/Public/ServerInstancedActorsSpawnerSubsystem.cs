namespace AssetTool
{
    [JsonAsset("ServerInstancedActorsSpawnerSubsystem")]
    public class UServerInstancedActorsSpawnerSubsystem : UMassActorSpawnerSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}