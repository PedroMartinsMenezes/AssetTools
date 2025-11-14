namespace AssetTool
{
    [JsonAsset("ActorFactoryVolume")]
    public class UActorFactoryVolume : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}