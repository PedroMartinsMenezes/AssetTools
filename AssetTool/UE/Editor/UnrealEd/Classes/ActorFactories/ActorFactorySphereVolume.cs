namespace AssetTool
{
    [JsonAsset("ActorFactorySphereVolume")]
    public class UActorFactorySphereVolume : UActorFactoryVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}