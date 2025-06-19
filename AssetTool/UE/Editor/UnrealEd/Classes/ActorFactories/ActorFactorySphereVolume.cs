namespace AssetTool
{
    [JsonAsset("ActorFactorySphereVolume")]
    public class UActorFactorySphereVolume : UActorFactoryVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}