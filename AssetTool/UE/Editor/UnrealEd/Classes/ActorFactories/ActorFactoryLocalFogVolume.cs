namespace AssetTool
{
    [JsonAsset("ActorFactoryLocalFogVolume")]
    public class UActorFactoryLocalFogVolume : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}