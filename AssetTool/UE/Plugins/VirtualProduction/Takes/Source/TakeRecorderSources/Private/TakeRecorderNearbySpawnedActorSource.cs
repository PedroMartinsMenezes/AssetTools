namespace AssetTool
{
    [JsonAsset("TakeRecorderNearbySpawnedActorSource")]
    public class UTakeRecorderNearbySpawnedActorSource : UTakeRecorderSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}