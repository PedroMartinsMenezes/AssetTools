namespace AssetTool
{
    [JsonAsset("ActorFactoryVolume")]
    public class UActorFactoryVolume : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}