namespace AssetTool
{
    [JsonAsset("MassCrowdSpawnerSubsystem")]
    public class UMassCrowdSpawnerSubsystem : UMassActorSpawnerSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}