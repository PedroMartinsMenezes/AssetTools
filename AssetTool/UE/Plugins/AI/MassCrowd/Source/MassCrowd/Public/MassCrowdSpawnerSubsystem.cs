namespace AssetTool
{
    [JsonAsset("MassCrowdSpawnerSubsystem")]
    public class UMassCrowdSpawnerSubsystem : UMassActorSpawnerSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}