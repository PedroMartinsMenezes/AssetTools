namespace AssetTool
{
    [JsonAsset("ActorFactoryLocalFogVolume")]
    public class UActorFactoryLocalFogVolume : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}