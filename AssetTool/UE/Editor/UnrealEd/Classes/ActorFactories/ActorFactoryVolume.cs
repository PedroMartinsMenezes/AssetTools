namespace AssetTool
{
    [JsonAsset("ActorFactoryVolume")]
    public class UActorFactoryVolume : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}