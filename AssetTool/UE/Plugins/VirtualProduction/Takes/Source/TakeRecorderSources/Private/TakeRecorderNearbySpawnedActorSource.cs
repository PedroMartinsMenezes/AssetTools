namespace AssetTool
{
    [JsonAsset("TakeRecorderNearbySpawnedActorSource")]
    public class UTakeRecorderNearbySpawnedActorSource : UTakeRecorderSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}