namespace AssetTool
{
    [JsonAsset("ActorFactoryFieldSystem")]
    public class UActorFactoryFieldSystem : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}