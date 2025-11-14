namespace AssetTool
{
    [JsonAsset("ActorFactorySphereVolume")]
    public class UActorFactorySphereVolume : UActorFactoryVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}