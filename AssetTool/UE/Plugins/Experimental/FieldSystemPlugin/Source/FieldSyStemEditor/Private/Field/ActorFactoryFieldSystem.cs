namespace AssetTool
{
    [JsonAsset("ActorFactoryFieldSystem")]
    public class UActorFactoryFieldSystem : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}